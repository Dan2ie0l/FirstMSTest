using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using SeleniumExtras.PageObjects;

namespace UnitTestProject1
{
    
    public class HomePage
    {
        string url = "https://duckduckgo.com/";
        IWebDriver driver;


        public HomePage(IWebDriver driver)
        {
            
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        
        public void SearchingSomething(string text)
        {
            
            driver.Navigate().GoToUrl(url);
           
            IWebElement button = driver.FindElement(By.Id("search_button_homepage"));
            IWebElement input = driver.FindElement(By.Id("search_form_input_homepage"));

            input.SendKeys(text);
            button.Click();

        }
        [TestCleanup]
        public void CleanUp()
        {

            driver.Quit();

        }
    }
}
