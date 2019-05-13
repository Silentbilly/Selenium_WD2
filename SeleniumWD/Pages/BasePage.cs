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
        private IWebElement loginButton;
        [FindsBy(How = How.XPath, Using = ".//*[@class='header-logout']")]
        private IWebElement logoutButton;
        [FindsBy(How = How.XPath, Using = ".//*[@type='text']")]
        private IWebElement loginField;

        public IWebElement GetLoginButton()
        {
            return loginButton;
        }
        public IWebElement GetLogoutButton()
        {
            return logoutButton;
        }
        public IWebElement GetLoginField()
        {
            return loginField;
        }
    }
}