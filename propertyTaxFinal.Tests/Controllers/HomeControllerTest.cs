using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using propertyTaxFinal;
using propertyTaxFinal.Controllers;
using propertyTaxFinal.Models;

namespace propertyTaxFinal.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Calculate()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Calculate() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Calculate(PropertyTax pt)
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Calculate(pt) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Confirm(PropertyTax pt)
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Confirm(pt) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
