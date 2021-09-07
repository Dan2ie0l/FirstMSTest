using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using SeleniumExtras.PageObjects;

namespace UnitTestProject1
{
  
    [TestClass]
    public class TestClass
    {
        public string text = "selenium";
        private IWebDriver driver;

       
        [TestMethod]
        public void AreTextsSame()
        {
            driver = new ChromeDriver();
            HomePage home = new HomePage(driver);
            SearchPage search = new SearchPage(driver);
            home.SearchingSomething(text);
            search.Comparing(text);
           
        }
        [TestCleanup]
        public void CleanUp()
        {

            driver.Quit();

        }
    }
}
