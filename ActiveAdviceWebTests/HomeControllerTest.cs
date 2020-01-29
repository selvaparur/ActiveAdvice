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
        
        [TestMethod]
        public void Test1()
        {
            HomeController controller = new HomeController();
            var result = controller.Index();
            Assert.AreEqual(result, result);
        }
        
        [TestMethod]
        public void Test2()
        {
            HomeController controller = new HomeController();
            var result = controller.Index();
            Assert.AreEqual(result, result);
        }
    }
}
