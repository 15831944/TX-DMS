using Db;
using Db.db;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Core.Model;
using System.Collections.Generic;
using System.Data.Common;

namespace DbTest
{
    
    
    /// <summary>
    ///This is a test class for DbPartReportTest and is intended
    ///to contain all DbPartReportTest Unit Tests
    ///</summary>
  [TestClass()]
  public class DbPartReportTest
  {


    private TestContext testContextInstance;

    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext
    {
      get
      {
        return testContextInstance;
      }
      set
      {
        testContextInstance = value;
      }
    }

    #region Additional test attributes
    // 
    //You can use the following additional attributes as you write your tests:
    //
    //Use ClassInitialize to run code before running the first test in the class
    //[ClassInitialize()]
    //public static void MyClassInitialize(TestContext testContext)
    //{
    //}
    //
    //Use ClassCleanup to run code after all tests in a class have run
    //[ClassCleanup()]
    //public static void MyClassCleanup()
    //{
    //}
    //
    //Use TestInitialize to run code before running each test
    //[TestInitialize()]
    //public void MyTestInitialize()
    //{
    //}
    //
    //Use TestCleanup to run code after each test has run
    //[TestCleanup()]
    //public void MyTestCleanup()
    //{
    //}
    //
    #endregion




    /// <summary>
    ///1, Insert a data
    ///2, Get the inserted Data
    ///3, Update the data
    ///</summary>
    [TestMethod()]
    public void InsertGetUpdate()
    {
      DbPartReport target = new DbPartReport(); 
      PartReport report = new PartReport(){Task = new Task(){Id = 0},
        Operator = "tester",OperatorComment = "TestComment",MeasurementDatetime= new DateTime(2014,10,10),
        Auditor = "Auditor",AuditComment = "Audit comment", AuditDatetime = new DateTime(2014,10,10),
       Approver = "Approver", ApproveComment = "Approve comment",ApproveDatetime = new DateTime(2014,10,10)};
      target.InsertPartReport(report);

      var insertedTask = target.GetPartReportsByPart(report.Task);
      Assert.AreEqual(report.Id, insertedTask.Id);
      report.Task.Id = 2;
      target.UpdatePartReport(report);

      Assert.AreEqual(report.Task.Id,2);
    }
  }
}
