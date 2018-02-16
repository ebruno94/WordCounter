using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounterProject.Models;
using WordCounterProject.Controllers;

namespace WordCounterProject.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            HomeController controller = new HomeController();
            IActionResult indexView = controller.Index();
            ViewResult result = indexView as ViewResult;
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}
