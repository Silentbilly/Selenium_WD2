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
    class MainPage : BasePage
    {
        private IWebDriver driver;
        public MainPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

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