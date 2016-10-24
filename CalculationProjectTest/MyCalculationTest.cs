using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculationProject;

namespace CalculationProjectTest
{
    [TestClass]
    public class MyCalculationTest
    {
        [TestMethod]
        public void TestAdd()
        {
            var myCalculation = new MyCalculation();
            int result = myCalculation.Add(5, 5);
            Assert.AreEqual(10, result);
        }
    }
}
