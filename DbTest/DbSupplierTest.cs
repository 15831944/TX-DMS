using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Model;
using Db;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DbTest
{
    [TestClass()]
  public class DbSupplierTest
  {
    [TestMethod()]
    public void InsertGetUpdate()
    {
      var target = new DbSupplier();
      var report = new Supplier()
      {
        Id = -1,
        Name = "Supplier",
      };
      target.InsertSupplier(report);

      var insertedTask = target.GetSupplier(report.Id);
      Assert.AreEqual(insertedTask.Id, report.Id);
      report.Name= "Supplier2";
      target.UpdateSupplier(report);

      Assert.AreEqual(report.Name, "Supplier2");
    }
  }
}
