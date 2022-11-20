using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalcualtorLib;


namespace CalcualtorLibTest
{
    [TestClass]
    public class UnitTestMultiply
    {
        [TestMethod]
        public void TestMultiply()
        {
            try
            {
                string result = SimpleCalculator.Multiply("5", "5");
                Assert.AreEqual("25", result);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}
