using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestAdd()
        {
            MathsCalculator calculator = new MathsCalculator();
            double expected = 10;
            double actual = calculator.Add(5,5);
            Assert.AreEqual(expected, actual);
        }
    }
}
