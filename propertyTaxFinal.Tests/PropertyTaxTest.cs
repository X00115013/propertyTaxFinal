using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using propertyTaxFinal.Models;

namespace propertyTaxFinal.Tests
{

    [TestClass]
    public class PropertyTaxTest
    {
        [TestMethod]
        public void amountInTest() {
            PropertyTax taxTest = new PropertyTax();
            int result = taxTest.amountIn = 5;
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void PropertyValueBandTest()
        {
            PropertyTax taxTest = new PropertyTax();
            taxTest.amountIn = 70000;
            string result = taxTest.PropertyValueBand;
            Assert.AreEqual("Between 0 and 100,000", result);
        }

        [TestMethod]
        public void CalculateTest()
        {
            PropertyTax taxTest = new PropertyTax();
            taxTest.amountIn = 425000;
            double result = taxTest.Calculate;
            Assert.AreEqual(765, result);
        }

        [TestMethod]
        public void nameTest()
        {
            PropertyTax taxTest = new PropertyTax();
            string result = taxTest.name = "Tom";
            Assert.AreEqual("Tom", result);
        }
    }
}
