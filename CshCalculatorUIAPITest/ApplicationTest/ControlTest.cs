using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathCalcualtorLib;
using System;

namespace CshConsoleTest.ApplicationTest
{
    [TestClass]
    public class ControlTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                string result = SimpleCalculator.Add("5", "2");
                Assert.AreEqual("7", result);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }

        }
}
}
