using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lhg.SoccerVirtual.Api;
using Lhg.SoccerVirtual.Api.Controllers;

namespace Lhg.SoccerVirtual.Api.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
