using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserCalcualtorUI;



namespace CshCalcualtorUserAppTest
{
    [TestClass]
    public class UnitTestMultiply
    {
         [TestMethod]
        public void TestIntegersMultiply()
        {
            ApplicationGUI dut = new ApplicationGUI();
            try
            {
                string result = dut.CmdMultiply("5", "5");
                Assert.AreEqual("25", result);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestIntegersMultiply2()
        {
            ApplicationGUI dut = new ApplicationGUI();
            try
            {
                string result = dut.CmdMultiply("50", "50");
                Assert.AreEqual("2500", result);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}
