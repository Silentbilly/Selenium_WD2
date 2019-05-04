using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumWD
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        [FindsBy(How = How.XPath, Using = ".//*[@type='submit']")]
        protected IWebElement loginButton;
        [FindsBy(How = How.XPath, Using = ".//*[@class='header-logout']")]
        protected IWebElement logoutButton;
        [FindsBy(How = How.XPath, Using = ".//*[@type='text']")]
        protected IWebElement loginField;
    }
}