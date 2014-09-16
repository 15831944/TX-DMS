using System.Diagnostics;
using Mediator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MediatorTest
{
    
    
    /// <summary>
    ///This is a test class for MediatorTest and is intended
    ///to contain all MediatorTest Unit Tests
    ///</summary>
  [TestClass()]
  public class MediatorTest
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
    ///A test for Mediator Constructor
    ///</summary>
    [TestMethod()]
    [DeploymentItem("Mediator.dll")]
    public void MediatorConstructorTest()
    {
      Mediator_Accessor target = new Mediator_Accessor();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for Cast
    ///</summary>
    public void CastTestHelper<T>()
    {
      object i_Target = null; // TODO: Initialize to an appropriate value
      T i_Example = default(T); // TODO: Initialize to an appropriate value
      T expected = default(T); // TODO: Initialize to an appropriate value
      T actual;
      actual = Mediator.Mediator.Cast<T>(i_Target, i_Example);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    [TestMethod()]
    public void CastTest()
    {
      CastTestHelper<GenericParameterHelper>();
    }

    /// <summary>
    ///A test for CreateChildRelationship
    ///</summary>
    [TestMethod()]
    public void CreateChildRelationshipTest()
    {
      Mediator_Accessor target = new Mediator_Accessor(); // TODO: Initialize to an appropriate value
      object i_ParentObject = null; // TODO: Initialize to an appropriate value
      object i_Vm = null; // TODO: Initialize to an appropriate value
      Action<object> i_AddAction = null; // TODO: Initialize to an appropriate value
      target.CreateChildRelationship(i_ParentObject, i_Vm, i_AddAction);
      Assert.Inconclusive("A method that does not return a value cannot be verified.");
    }

    /// <summary>
    ///A test for DestroyChildRelationship
    ///</summary>
    [TestMethod()]
    public void DestroyChildRelationshipTest()
    {
      Mediator_Accessor target = new Mediator_Accessor(); // TODO: Initialize to an appropriate value
      object i_Parent = null; // TODO: Initialize to an appropriate value
      object i_Child = null; // TODO: Initialize to an appropriate value
      Action<object> i_RemoveAction = null; // TODO: Initialize to an appropriate value
      target.DestroyChildRelationship(i_Parent, i_Child, i_RemoveAction);
      Assert.Inconclusive("A method that does not return a value cannot be verified.");
    }

    /// <summary>
    ///A test for DumpMessages
    ///</summary>
    [TestMethod()]
    public void DumpMessagesTest()
    {
      Mediator_Accessor target = new Mediator_Accessor(); // TODO: Initialize to an appropriate value
      target.DumpMessages();
      Assert.Inconclusive("A method that does not return a value cannot be verified.");
    }

    /// <summary>
    ///A test for EmptyHoldingPen
    ///</summary>
    [TestMethod()]
    public void EmptyHoldingPenTest()
    {
      Mediator_Accessor target = new Mediator_Accessor(); // TODO: Initialize to an appropriate value
      object i_Message = null; // TODO: Initialize to an appropriate value
      target.EmptyHoldingPen(i_Message);
      Assert.Inconclusive("A method that does not return a value cannot be verified.");
    }

    /// <summary>
    ///A test for GetKeyCallbackCount
    ///</summary>
    [TestMethod()]
    public void GetKeyCallbackCountTest()
    {
      Mediator_Accessor target = new Mediator_Accessor(); // TODO: Initialize to an appropriate value
      object i_Key = null; // TODO: Initialize to an appropriate value
      int expected = 0; // TODO: Initialize to an appropriate value
      int actual;
      actual = target.GetKeyCallbackCount(i_Key);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for GetTypeValueKey
    ///</summary>
    [TestMethod()]
    [DeploymentItem("Mediator.dll")]
    public void GetTypeValueKeyTest()
    {
      object i_Message = null; // TODO: Initialize to an appropriate value
      object expected = null; // TODO: Initialize to an appropriate value
      object actual;
      actual = Mediator_Accessor.GetTypeValueKey(i_Message);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for IsKeyRegistered
    ///</summary>
    [TestMethod()]
    public void IsKeyRegisteredTest()
    {
      Mediator_Accessor target = new Mediator_Accessor(); // TODO: Initialize to an appropriate value
      object i_Message = null; // TODO: Initialize to an appropriate value
      bool expected = false; // TODO: Initialize to an appropriate value
      bool actual;
      actual = target.IsKeyRegistered(i_Message);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for IsRegistered
    ///</summary>
    [TestMethod()]
    public void IsRegisteredTest()
    {
      Mediator_Accessor target = new Mediator_Accessor(); // TODO: Initialize to an appropriate value
      object i_Obj = null; // TODO: Initialize to an appropriate value
      bool expected = false; // TODO: Initialize to an appropriate value
      bool actual;
      actual = target.IsRegistered(i_Obj);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for NotifyColleagues
    ///</summary>
    [TestMethod()]
    public void NotifyColleaguesTest()
    {
      Mediator_Accessor target = new Mediator_Accessor(); // TODO: Initialize to an appropriate value
      object i_Message = null; // TODO: Initialize to an appropriate value
      object i_Args = null; // TODO: Initialize to an appropriate value
      target.NotifyColleagues(i_Message, i_Args);
      Assert.Inconclusive("A method that does not return a value cannot be verified.");
    }

    /// <summary>
    ///A test for NotifyColleaguesAsync
    ///</summary>
    [TestMethod()]
    public void NotifyColleaguesAsyncTest()
    {
      Mediator_Accessor target = new Mediator_Accessor(); // TODO: Initialize to an appropriate value
      object i_Message = null; // TODO: Initialize to an appropriate value
      object i_Args = null; // TODO: Initialize to an appropriate value
      target.NotifyColleaguesAsync(i_Message, i_Args);
      Assert.Inconclusive("A method that does not return a value cannot be verified.");
    }

    /// <summary>
    ///A test for NotifyLastColleague
    ///</summary>
    [TestMethod()]
    public void NotifyLastColleagueTest()
    {
      Mediator_Accessor target = new Mediator_Accessor(); // TODO: Initialize to an appropriate value
      object i_Message = null; // TODO: Initialize to an appropriate value
      object i_Args = null; // TODO: Initialize to an appropriate value
      target.NotifyLastColleague(i_Message, i_Args);
      Assert.Inconclusive("A method that does not return a value cannot be verified.");
    }

    /// <summary>
    ///A test for NotifyLastColleagueAsync
    ///</summary>
    [TestMethod()]
    public void NotifyLastColleagueAsyncTest()
    {
      Mediator_Accessor target = new Mediator_Accessor(); // TODO: Initialize to an appropriate value
      object i_Message = null; // TODO: Initialize to an appropriate value
      object i_Args = null; // TODO: Initialize to an appropriate value
      target.NotifyLastColleagueAsync(i_Message, i_Args);
      Assert.Inconclusive("A method that does not return a value cannot be verified.");
    }

    /// <summary>
    ///A test for Register
    ///</summary>
    [TestMethod()]
    public void RegisterTest()
    {
      Mediator_Accessor target = new Mediator_Accessor(); // TODO: Initialize to an appropriate value
      object i_Message = null; // TODO: Initialize to an appropriate value
      Action<object> i_Callback = null; // TODO: Initialize to an appropriate value
      Options i_Option = new Options(); // TODO: Initialize to an appropriate value
      target.Register(i_Message, i_Callback, i_Option);
      Assert.Inconclusive("A method that does not return a value cannot be verified.");
    }

    /// <summary>
    ///A test for UnRegister
    ///</summary>
    [TestMethod()]
    public void UnRegisterTest()
    {
      Mediator_Accessor target = new Mediator_Accessor(); // TODO: Initialize to an appropriate value
      target.UnRegister();
      Assert.Inconclusive("A method that does not return a value cannot be verified.");
    }

    /// <summary>
    ///A test for UnRegister
    ///</summary>
    [TestMethod()]
    public void UnRegisterTest1()
    {

      Mediator.Mediator target = Mediator.Mediator.Instance;
      MockObject m = new MockObject();
      Assert.AreEqual(true, target.IsRegistered(m));
      target.NotifyColleagues(1, 5);
      Assert.AreEqual(5, m.Index);
      target.UnRegister(m._Action);
      
      target.NotifyColleagues(1,10);
      Assert.AreEqual(5,m.Index);
    }


    class MockObject
    {
      
      public MockObject()
      {
        Mediator.Mediator target = Mediator.Mediator.Instance;
        _Action = test;
        target.Register(1, _Action);
      }

      public int Index = 0;

      public Action<object> _Action; 
      private void test(object i_O)
      {
        Index = (int)i_O;
      }
    }
    /// <summary>
    ///A test for UnRegisterObject
    ///</summary>
    [TestMethod()]
    public void UnRegisterObjectTest()
    {
      Mediator.Mediator target = Mediator.Mediator.Instance;
      MockObject m = new MockObject();
      Assert.AreEqual(true, target.IsRegistered(m));
      target.UnRegisterObject(m);
      Assert.AreEqual(false,target.IsRegistered(m));
      Debug.WriteLine((char)1060);
    }

    /// <summary>
    ///A test for DoBreakOnWarnings
    ///</summary>
    [TestMethod()]
    public void DoBreakOnWarningsTest()
    {
      Mediator_Accessor target = new Mediator_Accessor(); // TODO: Initialize to an appropriate value
      bool expected = false; // TODO: Initialize to an appropriate value
      bool actual;
      target.DoBreakOnWarnings = expected;
      actual = target.DoBreakOnWarnings;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for Instance
    ///</summary>
    [TestMethod()]
    public void InstanceTest()
    {
      Mediator.Mediator actual;
      actual = Mediator.Mediator.Instance;
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}
