using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using SeleniumExtras.PageObjects;

namespace UnitTestProject1
{

    class SearchPage
    {
        IWebDriver driver;

        public void Comparing(string text)
        {
            IWebElement input2 = driver.FindElement(By.Id("search_form_input"));
            string text2 = input2.GetAttribute("value");
            Assert.AreEqual(text, text2);
        }

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}
