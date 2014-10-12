using Db;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Core.Model;
using System.Collections.Generic;
using System.Data.Common;

namespace DbTest
{
    
    
    /// <summary>
    ///This is a test class for DbUserTest and is intended
    ///to contain all DbUserTest Unit Tests
    ///</summary>
  [TestClass()]
  public class DbUserTest
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
    ///A test for DbUser Constructor
    ///</summary>
    [TestMethod()]
    public void DbUserConstructorTest()
    {
      DbUser target = new DbUser();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for GetUserGroup
    ///</summary>
    [TestMethod()]
    [DeploymentItem("Db.dll")]
    public void GetUserGroupTest()
    {
      DbUser_Accessor target = new DbUser_Accessor(); // TODO: Initialize to an appropriate value
      int i_Id = 0; // TODO: Initialize to an appropriate value
      List<UserGroup> expected = null; // TODO: Initialize to an appropriate value
      List<UserGroup> actual;
      actual = target.GetUserGroup(i_Id);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for GetUsers
    ///</summary>
    [TestMethod()]
    public void GetUsersTest()
    {
      DbUser target = new DbUser(); // TODO: Initialize to an appropriate value
      string i_Name = string.Empty; // TODO: Initialize to an appropriate value
      List<User> expected = null; // TODO: Initialize to an appropriate value
      List<User> actual;
      actual = target.GetUsers(i_Name);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for GetUsers
    ///</summary>
    [TestMethod()]
    public void GetUsersTest1()
    {
      DbUser target = new DbUser(); // TODO: Initialize to an appropriate value
      List<User> expected = null; // TODO: Initialize to an appropriate value
      List<User> actual;
      actual = target.GetUsers();
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for PopulateUser
    ///</summary>
    [TestMethod()]
    [DeploymentItem("Db.dll")]
    public void PopulateUserTest()
    {
      DbUser_Accessor target = new DbUser_Accessor(); // TODO: Initialize to an appropriate value
      DbDataReader i_Reader = null; // TODO: Initialize to an appropriate value
      User expected = null; // TODO: Initialize to an appropriate value
      User actual;
      actual = target.PopulateUser(i_Reader);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for PopulateUserGroup
    ///</summary>
    [TestMethod()]
    [DeploymentItem("Db.dll")]
    public void PopulateUserGroupTest()
    {
      DbUser_Accessor target = new DbUser_Accessor(); // TODO: Initialize to an appropriate value
      DbDataReader i_Reader = null; // TODO: Initialize to an appropriate value
      UserGroup expected = null; // TODO: Initialize to an appropriate value
      UserGroup actual;
      actual = target.PopulateUserGroup(i_Reader);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}
