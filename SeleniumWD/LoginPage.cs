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
        private IWebDriver driver;
        public LoginPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);               
            this.driver = driver;
        }

        [FindsBy(How = How.XPath, Using = ".//*[@type='password']")]
        private IWebElement passwordField;

        public LoginPage SetLogin(String login)
        {
            new Actions(driver).SendKeys(loginField, login).Build().Perform();
            return this;                                                       
        }
        public LoginPage SetPassword(String password)
        {
            new Actions(driver).SendKeys(passwordField, password).Build().Perform();
            return this;
        }
        public LoginPage Login()
        {
            new Actions(driver).Click().Click(loginButton).Build().Perform();
            return this;
        }
        public void Login(string login, string password)
        {
            SetLogin(login).SetPassword(password).Login();
        }

        public bool isLoginPerformedSucceslly()
        {
            try
            {
                return !loginField.Displayed;
            }
            catch (Exception e)
            {
                return true;
            }
        }
    }
        
}