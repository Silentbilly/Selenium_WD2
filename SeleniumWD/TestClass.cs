// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWD
{
    [TestFixture]
    public class TestClass
    {
        IWebDriver driver = new ChromeDriver();  
        [OneTimeSetUp]
        public void Init()
        {
            driver.Url = "http://localhost:3030/admin";
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            driver.Quit();
        }


        [TearDown] 
        public void AfterTest()
        {
            Thread.Sleep(1000);
        }

        // Tests.
        [Test, Order(1)]                  
        public void Login()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("admin", "admin");
            Thread.Sleep(1000); 
            Assert.IsTrue(loginPage.isLoginPerformedSucceslly(), "Login is failed.");
        }

        [TestCaseSource(typeof(DataSource), "DataTest"), Order(2)]

        public void NewPost(string title, string url, string body)
        {
            PostEditorPage postEditor = new PostEditorPage(driver);
            postEditor.Publish(title, url, body);
            driver.Url = "http://localhost:3030/admin";
            Thread.Sleep(300);
            Assert.AreEqual(title, postEditor.getPostedTitle());   
            Assert.AreEqual(body, postEditor.getPostedBody());
        }

        [Test]
        public void Logout()
        {
            MainPage logout = new MainPage(driver);
            logout.Logout();
            Assert.IsTrue(logout.isLogoutPerformedSucceslly(), "Logout is failed.");
        } 
    }
}