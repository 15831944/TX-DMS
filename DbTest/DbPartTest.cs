using Db;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Core.Model;
using System.Collections.Generic;

namespace DbTest
{
    
    
    /// <summary>
    ///This is a test class for DbPartTest and is intended
    ///to contain all DbPartTest Unit Tests
    ///</summary>
  [TestClass()]
  public class DbPartTest
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
    ///A test for DbPart Constructor
    ///</summary>
    [TestMethod()]
    public void DbPartConstructorTest()
    {
      DbPart target = new DbPart();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for GetPartById
    ///</summary>
    [TestMethod()]
    public void GetPartByIdTest()
    {
      DbPart target = new DbPart(); // TODO: Initialize to an appropriate value
      int i_Id = 0; // TODO: Initialize to an appropriate value
      Part expected = null; // TODO: Initialize to an appropriate value
      Part actual;
      actual = target.GetPartById(i_Id);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for GetPartWithCondition
    ///</summary>
    [TestMethod()]
    [DeploymentItem("Db.dll")]
    public void GetPartWithConditionTest()
    {
      DbPart_Accessor target = new DbPart_Accessor(); // TODO: Initialize to an appropriate value
      string i_Condition = string.Empty; // TODO: Initialize to an appropriate value
      Part expected = null; // TODO: Initialize to an appropriate value
      Part actual;
      actual = target.GetPartWithCondition(i_Condition);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for GetParts
    ///</summary>
    [TestMethod()]
    public void GetPartsTest()
    {
      DbPart target = new DbPart(); // TODO: Initialize to an appropriate value
      List<Part> expected = null; // TODO: Initialize to an appropriate value
      List<Part> actual;
      actual = target.GetParts();
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for GetPartsByCadNumber
    ///</summary>
    [TestMethod()]
    public void GetPartsByCadNumberTest()
    {
      DbPart target = new DbPart(); // TODO: Initialize to an appropriate value
      string i_CadNumber = string.Empty; // TODO: Initialize to an appropriate value
      List<Part> expected = null; // TODO: Initialize to an appropriate value
      List<Part> actual;
      actual = target.GetPartsByCadNumber(i_CadNumber);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for InsertPart
    ///</summary>
    [TestMethod()]
    public void InsertPartTest()
    {
      DbPart target = new DbPart(); // TODO: Initialize to an appropriate value
      Part i_Part = null; // TODO: Initialize to an appropriate value
      target.InsertPart(i_Part);
      Assert.Inconclusive("A method that does not return a value cannot be verified.");
    }

    /// <summary>
    ///A test for UpdatePart
    ///</summary>
    [TestMethod()]
    public void UpdatePartTest()
    {
      DbPart target = new DbPart(); // TODO: Initialize to an appropriate value
      Part i_Part = null; // TODO: Initialize to an appropriate value
      int expected = 0; // TODO: Initialize to an appropriate value
      int actual;
      actual = target.UpdatePart(i_Part);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}
