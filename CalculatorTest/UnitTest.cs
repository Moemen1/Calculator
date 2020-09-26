using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]      
        public void CalculateAnswerTest()
        {
            CalculatorForm form = new CalculatorForm();

            double actual = 5;
            double expected = form.calculateAnswer("-", 10d, 5d);

            Assert.AreEqual(actual, expected);
        }
    }
}
