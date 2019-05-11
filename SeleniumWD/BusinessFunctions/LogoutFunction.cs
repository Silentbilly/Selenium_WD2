using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWD.BusinessFunctions
{
    class LogoutFunction
    {
        public IWebDriver driver;
        public LogoutFunction(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void Logout()
        {
            new MainPage(driver).Logout();
        }
    }
}
