///////////////////////////////////////////////////////////////////////////////
// Copyright © 2009-2010, Open Design Alliance (the "Alliance") 
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
// Teigha™.NET for .dwg files 2009-2010 by Open Design Alliance. All rights reserved.
//
// By use of this software, you acknowledge and accept these terms.
//
//
// *DWG is the native and proprietary file format for AutoCAD® and a trademark 
// of Autodesk, Inc. The Open Design Alliance is not associated with Autodesk.
///////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using Dwglib;
using Teigha.DatabaseServices;
using Teigha.Geometry;
using Teigha.GraphicsInterface;
using Teigha.Colors;
using Teigha;
using Trace = Teigha.DatabaseServices.Trace;

// note that GetObject doesn't work in Acad 2009, so we use "obsolete" Open instead
#pragma warning disable 618

namespace OdReadExMgd
{
  class ExProtocolExtension
  {
  }
  class Program
  {
    static void Main(string[] args)
    {
      /********************************************************************/
      /* Initialize Teigha.                                            */
      /********************************************************************/
      using (Teigha.Runtime.Services srv = new Teigha.Runtime.Services())
      {
        try
        {
          /******************************************************************/
          /* Create a database and load the drawing into it.                
          /* first parameter means - do not initialize database- it will be read from file
           * second parameter is not used by DD.NET - it is left for ARX compatibility.
           * Note the 'using' clause - generally, wrappers should disposed after use, 
           * to close underlying database objects
          /******************************************************************/
          using (Database pDb = new Database(false, false))
          {
            pDb.ReadDwgFile(args[0], FileShare.Read, true, "");
            /****************************************************************/
            /* Display the File Version                                     */
            /****************************************************************/
            Console.WriteLine("File Version: {0}", pDb.OriginalFileVersion);
            /****************************************************************/
            /* Dump the database                                            */
            /****************************************************************/
            DbDumper dumper = new DbDumper();
            dumper.dump(pDb, 0);
          }
        }
        /********************************************************************/
        /* Display the error                                                */
        /********************************************************************/
        catch (System.Exception e)
        {
          Console.WriteLine("Teigha™.NET for .dwg files Error: " + e.Message);
        }
      }
    }
  }
}
