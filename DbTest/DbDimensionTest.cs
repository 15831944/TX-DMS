using Db;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Core.Model;
using System.Collections.Generic;
using System.Data.Common;

namespace DbTest
{
    
    
    /// <summary>
    ///This is a test class for DbDimensionTest and is intended
    ///to contain all DbDimensionTest Unit Tests
    ///</summary>
  [TestClass()]
  public class DbDimensionTest
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
    ///A test for InsertDimension
    ///</summary>
    [TestMethod()]
    public void InsertDimensionTest()
    {
      DbDimension target = new DbDimension(); // TODO: Initialize to an appropriate value
      Dimension i_Dimension = null; // TODO: Initialize to an appropriate value
      target.InsertDimension(i_Dimension);
      Assert.Inconclusive("A method that does not return a value cannot be verified.");
    }

    /// <summary>
    ///A test for GetDimensionsByPart
    ///</summary>
    [TestMethod()]
    public void GetDimensionsByPartTest()
    {
      DbDimension target = new DbDimension(); // TODO: Initialize to an appropriate value
      Part i_Part = null; // TODO: Initialize to an appropriate value
      List<Dimension> expected = null; // TODO: Initialize to an appropriate value
      List<Dimension> actual;
      actual = target.GetDimensionsByPart(i_Part);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for GetDimensionsByMeasureMentReport
    ///</summary>
    [TestMethod()]
    public void GetDimensionsByMeasureMentReportTest()
    {
      DbDimension target = new DbDimension(); // TODO: Initialize to an appropriate value
      PartReport i_PartReport = null; // TODO: Initialize to an appropriate value
      List<Dimension> expected = null; // TODO: Initialize to an appropriate value
      List<Dimension> actual;
      actual = target.GetDimensionsByMeasureMentReport(i_PartReport);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for GetDimensions
    ///</summary>
    [TestMethod()]
    public void GetDimensionsTest()
    {
      DbDimension target = new DbDimension(); // TODO: Initialize to an appropriate value
      List<Dimension> expected = null; // TODO: Initialize to an appropriate value
      List<Dimension> actual;
      actual = target.GetDimensions();
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for DeleteDimension
    ///</summary>
    [TestMethod()]
    public void DeleteDimensionTest()
    {
      DbDimension target = new DbDimension(); // TODO: Initialize to an appropriate value
      Dimension i_Dimension = null; // TODO: Initialize to an appropriate value
      int expected = 0; // TODO: Initialize to an appropriate value
      int actual;
      actual = target.DeleteDimension(i_Dimension);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for DbDimension Constructor
    ///</summary>
    [TestMethod()]
    public void DbDimensionConstructorTest()
    {
      DbDimension target = new DbDimension();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for PopulateADimension
    ///</summary>
    [TestMethod()]
    [DeploymentItem("Db.dll")]
    public void PopulateADimensionTest()
    {
      DbDimension_Accessor target = new DbDimension_Accessor(); // TODO: Initialize to an appropriate value
      DbDataReader i_Reader = null; // TODO: Initialize to an appropriate value
      Dimension expected = null; // TODO: Initialize to an appropriate value
      Dimension actual;
      actual = target.PopulateADimension(i_Reader);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for UpdateDimension
    ///</summary>
    [TestMethod()]
    public void UpdateDimensionTest()
    {
      DbDimension target = new DbDimension(); // TODO: Initialize to an appropriate value
      Dimension i_Dimension = null; // TODO: Initialize to an appropriate value
      int expected = 0; // TODO: Initialize to an appropriate value
      int actual;
      actual = target.UpdateDimension(i_Dimension);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for UpdateDimensions
    ///</summary>
    [TestMethod()]
    public void UpdateDimensionsTest()
    {
      DbDimension target = new DbDimension(); // TODO: Initialize to an appropriate value
      List<Dimension> i_Dimensions = null; // TODO: Initialize to an appropriate value
      target.UpdateDimensions(i_Dimensions);
      Assert.Inconclusive("A method that does not return a value cannot be verified.");
    }
  }
}
