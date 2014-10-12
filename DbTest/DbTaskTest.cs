using Core.Model;
using Db;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DbTest
{
    
    
    /// <summary>
    ///This is a test class for DbTaskTest and is intended
    ///to contain all DbTaskTest Unit Tests
    ///</summary>
  [TestClass()]
  public class DbTaskTest
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
    ///A test for DbTask Constructor
    ///</summary>
    [TestMethod()]
    public void InsertGetUpdate()
    {
      DbTask target = new DbTask();
      Task report = new Task()
      {
        CreateDatetime = new DateTime(2014, 10, 10),
        Supplier = new Supplier(){Id = -1},
        Name = "task",
        Part = new Part(){Id = -1},
        SampleNumber = 10,
        TotalNumber = 1000
      };
      target.InsertTask(report);

      var insertedTask =  target.GetTask(report);
      Assert.AreEqual(insertedTask.Id, report.Id);
      report.Supplier.Id = 2;
      target.UpdateTask(report);

      Assert.AreEqual(report.Supplier.Id, 2);
    }
  }
}
