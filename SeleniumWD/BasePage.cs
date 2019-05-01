//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Interactions;
//using OpenQA.Selenium.Support.PageObjects;

//namespace SeleniumWD
//{
//    public abstract class BasePage
//    {
//        public IWebDriver driver;

//        public BasePage(IWebDriver driver)
//        {
//            PageFactory.InitElements(driver, this);
//            this.driver = driver;
//        }

//        [FindsBy(How = How.XPath, Using = ".//*[@class='header-logout']")]
//        public IWebElement logoutButton;
//        [FindsBy(How = How.XPath, Using = ".//*[@type='text']")]
//        public IWebElement loginField;


//    }
//}
