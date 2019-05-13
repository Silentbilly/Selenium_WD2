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
        public MainPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        public void Logout()
        {
            GetLogoutButton().Click();
        }

        public bool IsLogoutPerformedSucceslly()
        {
            try
            {
                return GetLoginButton().Displayed;
            }
            catch (Exception e)
            {
                return true;
            }
        }
    }
}