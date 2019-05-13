using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWD.Utils
{
    class GoToPage
    {
        public IWebDriver driver;
        public GoToPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
        public void GoToHomePage()
        {
            driver.Url = "http://localhost:3030/admin";
        }
    }
}
