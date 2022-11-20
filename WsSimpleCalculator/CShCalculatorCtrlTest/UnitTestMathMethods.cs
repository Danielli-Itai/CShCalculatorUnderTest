using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalcualtorCtrl;



namespace CShCalculatorCtrlTest
{
    [TestClass]
    public class UnitTestMathMethods
    {
        [TestMethod]
        public void TestAddMethod()
        {
            try
            {
                MathCalculatorCtrl ctrl = new MathCalculatorCtrl();
                string result = ctrl.CmdAdd("5", "2");
                Assert.AreEqual("7", result);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }

        }
    }
}
