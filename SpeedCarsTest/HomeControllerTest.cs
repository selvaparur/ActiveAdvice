using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpeedCarsWeb.Controllers;

namespace SpeedCarsTest
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void HomeIndexTest()
        {
            HomeController controller = new HomeController();
            var result = controller.Index();
            Assert.AreEqual(result, result);
        }
    }
}
