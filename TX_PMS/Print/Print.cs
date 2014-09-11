///////////////////////////////////////////////////////////////////////////////
// Copyright � 2009-2010, Open Design Alliance (the "Alliance") 
// 
// This software is owned by the Alliance, and may only be incorporated into 
// application programs owned by members of the Alliance subject to a signed 
// Membership Agreement and Supplemental Software License Agreement with the
// Alliance. The structure and organization of this software are the valuable 
// trade secrets of the Alliance and its suppliers. The software is also 
// protected by copyright law and international treaty provisions. Application 
// programs incorporating this software must include the following statement 
// with their copyright notices:
//
// Teigha�.NET for .dwg files 2009-2010 by Open Design Alliance. All rights reserved.
//
// By use of this software, you acknowledge and accept these terms.
//
//
// *DWG is the native and proprietary file format for AutoCAD� and a trademark 
// of Autodesk, Inc. The Open Design Alliance is not associated with Autodesk.
///////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Printing;
using Dwglib;
using Teigha;
using Teigha.DatabaseServices;
using Teigha.GraphicsSystem;
using Teigha.Runtime;
using Teigha.GraphicsInterface;
using Teigha.Geometry;


namespace TxPms.Print
{
  class Printing
  {
    Teigha.GraphicsSystem.LayoutHelperDevice m_pPrinterDevice;
    Database database;
    Teigha.GraphicsSystem.View pViewDr;

    public void Swap<T>(T a, T b)
    {
      T temp;
      temp = a;
      a = b;
      b = temp;
    }

    void PrintPage(object sender, PrintPageEventArgs ev)
    {
      if (m_pPrinterDevice != null)
      {
        using (DBObject pVpObj = Aux.active_viewport_id(database).GetObject(OpenMode.ForWrite))
        {
          using(AbstractViewportData pAV = new AbstractViewportData(pVpObj))
          {
            Teigha.GraphicsSystem.View pGSView = pAV.GsView;

            PrintDocument prDoc = (PrintDocument)sender;

            // Get printer paper info
            Double dPrinterWidth = ev.PageBounds.Width;
            Double dPrinterHeight = ev.PageBounds.Height;
            Double dLogPixelX = ev.PageSettings.PrinterResolution.X; //dot per inch
            Double dLogPixelY = ev.PageSettings.PrinterResolution.Y; //dot per inch
            Double kMmPerInch = 25.4;
            Double kMmPerHInch = 0.254;
            Double koeffX = dLogPixelX / kMmPerInch;
            Double koeffY = dLogPixelY / kMmPerInch;

            Layout pLayout = (Layout)m_pPrinterDevice.LayoutId.GetObject(OpenMode.ForRead);
            Boolean bScaledToFit = pLayout.UseStandardScale && (StdScaleType.ScaleToFit == pLayout.StdScaleType);
            Boolean bCentered = pLayout.PlotCentered;
            Boolean bMetric = (pLayout.PlotPaperUnits != PlotPaperUnit.Inches);
            Boolean bPrintLW = pLayout.PrintLineweights || pLayout.ShowPlotStyles;

            Point2d offsets = pLayout.PlotOrigin;        // in mm

            Extents2d ex2d = pLayout.PlotPaperMargins;
            Double dLeftMargin = ex2d.MinPoint.X; // in mm
            Double dRightMargin = ex2d.MaxPoint.X; // in mm
            Double dTopMargin = ex2d.MinPoint.Y; // in mm
            Double dBottomMargin = ex2d.MaxPoint.Y; // in mm
            PlotType plotType = pLayout.PlotType;

            PlotRotation plotRotation = pLayout.PlotRotation;
            if (plotRotation == PlotRotation.Degrees090 || plotRotation == PlotRotation.Degrees270)
            {
              plotRotation = (plotRotation == PlotRotation.Degrees090) ? PlotRotation.Degrees270 : PlotRotation.Degrees090;
            }

            switch (plotRotation)
            {
              case PlotRotation.Degrees090:
                Swap<Double>(dTopMargin, dRightMargin);
                Swap<Double>(dBottomMargin, dLeftMargin);
                Swap<Double>(dBottomMargin, dTopMargin);
                Swap<Double>(dTopMargin, dRightMargin);
                offsets = new Point2d(-offsets.X, -offsets.Y);
                break;
              case PlotRotation.Degrees180:
                Swap<Double>(dRightMargin, dLeftMargin);
                offsets = new Point2d(-offsets.X, -offsets.Y);
                break;
              case PlotRotation.Degrees270:
                Swap<Double>(dTopMargin, dRightMargin);
                Swap<Double>(dBottomMargin, dLeftMargin);
                Swap<Double>(dBottomMargin, dTopMargin);
                offsets = new Point2d(offsets.X, offsets.Y);
                break;
            }

            // Get scale factor
            double factor;
            if (pLayout.UseStandardScale)
            {
              factor = pLayout.StdScale;
            }
            else
            {
              CustomScale scale = pLayout.CustomPrintScale;
              factor = scale.Numerator / scale.Denominator;
            }

            // Calculate paper drawable area using margins from layout (in mm).
            Double drx1 = (ev.MarginBounds.Left * kMmPerHInch + dLeftMargin);                // in mm
            Double drx2 = (ev.MarginBounds.Width * kMmPerHInch - dLeftMargin - dRightMargin); // in mm
            Double dry1 = (ev.MarginBounds.Top * kMmPerHInch + dTopMargin);                // in mm
            Double dry2 = (ev.MarginBounds.Height * kMmPerHInch - dTopMargin - dBottomMargin); // in mm

            Boolean bType = (plotType == PlotType.Display || plotType == PlotType.Layout);
            AbstractViewPE pAbstractViewPE = new AbstractViewPE(bType ? pViewDr : pGSView);

            // set LineWeight scale factor for model space
            if (bPrintLW && database.TileMode)
            {
              Teigha.GraphicsSystem.View pTo = m_pPrinterDevice.ViewAt(0);
              pTo.LineweightToDcScale = Math.Max(dLogPixelX, dLogPixelY) / kMmPerInch * 0.01;
            }

            Point3d viewTarget = pAbstractViewPE.Target;
            Point3d viewportCenter = pAbstractViewPE.Target;       // in plotPaperUnits
            Boolean isPerspective = pAbstractViewPE.IsPerspective;
            Double viewportH = pAbstractViewPE.FieldHeight;  // in plotPaperUnits
            Double viewportW = pAbstractViewPE.FieldWidth;   // in plotPaperUnits
            Vector3d viewDir = pAbstractViewPE.Direction;    // in plotPaperUnits
            Vector3d upV = pAbstractViewPE.UpVector;     // in plotPaperUnits
            Matrix3d eyeToWorld = pAbstractViewPE.EyeToWorld;
            Matrix3d WorldToeye = pAbstractViewPE.WorldToEye;

            Boolean isPlanView = viewDir.GetNormal().Equals(Vector3d.ZAxis);
            Point3d oldTarget = viewTarget;

            Double fieldWidth = viewportW, fieldHeight = viewportH;

            if (plotType == PlotType.Display)
            {
              viewTarget = viewportCenter;
              fieldWidth = viewportW;
              fieldHeight = viewportH;
            }
            else if (plotType == PlotType.Extents || (plotType == PlotType.Limits && !isPlanView))
            {
              BoundBlock3d extents = new BoundBlock3d();
              if (pAbstractViewPE.GetViewExtents(extents)) // pIter also skip 'off layers'
              {
                extents.TransformBy(eyeToWorld);
                viewTarget = (extents.GetMinimumPoint() + extents.GetMaximumPoint().GetAsVector()) / 2.0;
                extents.TransformBy(WorldToeye);

                fieldWidth = Math.Abs(extents.GetMaximumPoint().X - extents.GetMinimumPoint().X);
                fieldHeight = Math.Abs(extents.GetMaximumPoint().Y - extents.GetMinimumPoint().Y);
              }
            }
            else if (plotType == PlotType.View)
            {
              viewTarget = viewportCenter;
              fieldWidth = viewportW;
              fieldHeight = viewportH;
            }
            else if (plotType == PlotType.Limits)
            {
              fieldWidth = (drx2 - drx1) / factor; // drx in mm -> fieldWidth in mm
              fieldHeight = (dry2 - dry1) / factor;

              viewTarget = new Point3d(fieldWidth / 2.0 - offsets.X / factor, fieldHeight / 2.0 - offsets.Y / factor, 0); // in mm
              if (!bMetric)
              {
                viewTarget /= kMmPerInch; // must be in plotpaper units
                fieldWidth /= kMmPerInch;
                fieldHeight /= kMmPerInch;
              }

              bCentered = bScaledToFit = false;       // kLayout doesn't support pIter.
            }

            if (plotType != PlotType.View)
              viewTarget = viewTarget.OrthoProject(new Plane(oldTarget, viewDir));

            pGSView.SetView(viewTarget + viewDir, viewTarget, upV, fieldWidth, fieldHeight, isPerspective ? Teigha.GraphicsSystem.Projection.Perspective : Teigha.GraphicsSystem.Projection.Parallel);

            if (!bMetric)
            {
              fieldWidth *= kMmPerInch;
              fieldHeight *= kMmPerInch;
            }

            if (bScaledToFit)
            {
              factor = Math.Min((drx2 - drx1) / fieldWidth, (dry2 - dry1) / fieldHeight);
            }

            if (bCentered)    // Offset also can be incorectly saved.
            {
              offsets = new Point2d(((drx2 - drx1) - fieldWidth * factor) / 2.0,
                                    ((dry2 - dry1) - fieldHeight * factor) / 2.0);

              if (plotRotation == PlotRotation.Degrees090 || plotRotation == PlotRotation.Degrees180)
              {
                offsets = new Point2d(-offsets.X, -offsets.Y);
              }
            }

            pGSView.Viewport = new Extents2d(0, 0, 1, 1);

            // Calculate viewport rect in printer units
            //int x1 = (int)((offsets.X + drx1) * koeffX);
            //int x2 = (int)((offsets.X + drx2) * koeffX);
            //int y1 = (int)((-offsets.Y + dry1) * koeffY);
            //int y2 = (int)((-offsets.Y + dry2) * koeffY);
            int x1 = (int)(drx1 * koeffX);
            int x2 = (int)(drx2 * koeffX);
            int y1 = (int)(dry1 * koeffY);
            int y2 = (int)(dry2 * koeffY);

            Rectangle viewportRect = new Rectangle(x1, y1, x2, y2);
            m_pPrinterDevice.OnSize(viewportRect);
            if (m_pPrinterDevice.UnderlyingDevice.Properties.Contains("WindowHDC"))
              m_pPrinterDevice.UnderlyingDevice.Properties.AtPut("WindowHDC", new RxVariant((Int32)ev.Graphics.GetHdc()));
            m_pPrinterDevice.Update();

            pAbstractViewPE.Dispose();
            pLayout.Dispose();
          }
        }
      }
    }




    public void Print(Database db, Teigha.GraphicsSystem.View pView, bool bPreview)
    {
      database = db;
      pViewDr = pView;
      ObjectId idLayout = database.CurrentSpaceId;
      using (BlockTableRecord btr = (BlockTableRecord)database.CurrentSpaceId.GetObject(OpenMode.ForRead))
      {
        using (Layout pLayout = (Layout)btr.LayoutId.GetObject(OpenMode.ForRead))
        {
          PrintDocument prDoc = new PrintDocument();
          prDoc.PrintPage += new PrintPageEventHandler(this.PrintPage);
          prDoc.PrinterSettings.PrinterName = pLayout.PlotConfigurationName;

          PageSettings pageSetting = prDoc.DefaultPageSettings;
          PlotRotation rotation = pLayout.PlotRotation;
          if (rotation == PlotRotation.Degrees090 || rotation == PlotRotation.Degrees270)
            pageSetting.Landscape = true;
          else
            pageSetting.Landscape = false;

          Double kMmPerInch = 10 / 2.54;
          Point2d ptPaperSize = pLayout.PlotPaperSize;
          PaperSize ps = new PaperSize(pLayout.CanonicalMediaName, (int)(ptPaperSize.X * kMmPerInch), (int)(ptPaperSize.Y * kMmPerInch));
          pageSetting.PaperSize = ps;

          //default as OdaMfc
          pageSetting.Margins.Left = 0;
          pageSetting.Margins.Right = 0;
          pageSetting.Margins.Top = 0;
          pageSetting.Margins.Bottom = 0;

          prDoc.DefaultPageSettings = pageSetting;
          if (prDoc.PrinterSettings.IsValid)
          {
            try
            {                                                                             //WinGDI, WinOpenGL
              using (GsModule gsModule = (GsModule)SystemObjects.DynamicLinker.LoadModule("WinGDI.txv", false, true))
              {
                using (Teigha.GraphicsSystem.Device graphichsDevice = gsModule.CreateDevice())
                {
                  using (ContextForDbDatabase ctx = new ContextForDbDatabase(database))
                  {
                    ctx.SetPlotGeneration(true);
                    ctx.UseGsModel = true;
                    m_pPrinterDevice = LayoutHelperDevice.SetupActiveLayoutViews(graphichsDevice, ctx);
                    m_pPrinterDevice.BackgroundColor = Color.FromArgb(0, 255, 255, 255);
                    m_pPrinterDevice.SetLogicalPalette(Device.LightPalette);

                    Aux.preparePlotstyles(database, ctx);
                  }
                }
              }
            }
            catch (System.Exception ex)
            {
              MessageBox.Show(ex.ToString());
            }

            if (bPreview)
            {
              PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
              printPreviewDialog.Document = prDoc;
              printPreviewDialog.ShowDialog();
            }
            else
            {
              prDoc.Print();
            }

            m_pPrinterDevice = null;
            database = null;
            pViewDr = null;
          }
        }
      }
    } 
  };
}