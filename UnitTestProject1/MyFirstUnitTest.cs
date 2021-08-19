using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class MyFirstUnitTest
    {
        string url = "https://duckduckgo.com/";
        string text = "selenium";
        IWebDriver driver = new ChromeDriver();

        [TestMethod]
        public void AreTextsSame()
        {
            
            driver.Navigate().GoToUrl(url);
           
            IWebElement button = driver.FindElement(By.Id("search_button_homepage"));
            IWebElement input = driver.FindElement(By.Id("search_form_input_homepage"));

            
            input.SendKeys(text);
            button.Click();

            IWebElement input2 = driver.FindElement(By.Id("search_form_input"));
            string text2 = input2.GetAttribute("value");
            Assert.AreEqual(text, text2);
            

        }
        [TestCleanup]
        public void CleanUp()
        {

            driver.Quit();

        }
    }
}
