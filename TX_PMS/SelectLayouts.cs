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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Teigha;
using Teigha.DatabaseServices;

namespace OdViewExMgd
{
  public partial class SelectLayouts : Form
  {
    public SelectLayouts(Database database)
    {
      InitializeComponent();

      using (DBDictionary layoutDict = (DBDictionary)database.LayoutDictionaryId.GetObject(OpenMode.ForRead))
      {
        foreach (DBDictionaryEntry dicEntry in layoutDict)
        {
          listBox1.Items.Add(dicEntry.Key);
        }
      }
    }

    public void CloseDlg()
    {
      LayoutManager LayMan = LayoutManager.Current;
      LayMan.CurrentLayout = listBox1.SelectedItem.ToString();
      Close();
    }

    private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      CloseDlg();
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
      CloseDlg();
    }
  }
}