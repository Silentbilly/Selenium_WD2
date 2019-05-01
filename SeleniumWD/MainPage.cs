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
    class MainPage
    {
        private IWebDriver driver;
        public MainPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        [FindsBy(How = How.XPath, Using = ".//*[@class='header-logout']")]
        private IWebElement logoutButton;
        [FindsBy(How = How.XPath, Using = ".//*[@type='submit']")]
        private IWebElement loginButton;

        public void Logout()
        {
            logoutButton.Click();
        }

        public bool isLogoutPerformedSucceslly()
        {
            try
            {
                return loginButton.Displayed;
            }
            catch (Exception e)
            {
                return true;
            }
        }
    }
}