using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SpeedCarsTests
{
    [TestClass]
    public class UIAutomatedTests
    {
        private IWebDriver driver;
        public string homeURL;

        [TestCleanup]
        public void TearDownTest()
        {
            driver.Close();
        }


        [TestInitialize]
        public void SetupTest()
        {
            homeURL = "https://sbx.azurewebsites.net";
            string driverPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
            driver = new ChromeDriver(driverPath);

        }

        
        public void Adding_cars_to_our_portal()
        {
            driver.Navigate().GoToUrl(homeURL);
            WebDriverWait wait = new WebDriverWait(driver,
System.TimeSpan.FromSeconds(10));
            wait.Until(driver =>
driver.FindElement(By.Id("txtname")));
            IWebElement elementname = driver.FindElement(By.Id("txtname"));
            IWebElement elementmodel = driver.FindElement(By.Id("txtmodel"));
            elementname.SendKeys("Ferrari");
            elementmodel.SendKeys("GTC4");
            driver.FindElement(By.Id("btnSave")).Click();
            Assert.AreEqual("Sign In", "Sign In");
        }


    }
}
