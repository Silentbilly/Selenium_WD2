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
    class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);               
            this.driver = driver;
        }

        [FindsBy(How = How.XPath, Using = ".//*[@type='password']")]
        private IWebElement passwordField;

        public LoginPage SetLogin(String login)
        {
            new Actions(driver).SendKeys(GetLoginField(), login).Build().Perform();
            return this;                                                       
        }
        public LoginPage SetPassword(String password)
        {
            new Actions(driver).SendKeys(passwordField, password).Build().Perform();
            return this;
        }
        public LoginPage Login()
        {
            new Actions(driver).Click().Click(GetLoginButton()).Build().Perform();
            return this;
        }
        public void Login(string login, string password)
        {
            SetLogin(login).SetPassword(password).Login();
        }

        public bool IsLoginPerformedSucceslly()
        {
            try
            {
                return !GetLoginField().Displayed;
            }
            catch (Exception e)
            {
                return true;
            }
        }
    }    
}