// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWD.BO;
using SeleniumWD.BusinessFunctions;
using SeleniumWD.Utils;

namespace SeleniumWD
{
    [TestFixture]
    public class TestClass
    {
        public static IWebDriver driver = new ChromeDriver();
        GoToPage goPage = new GoToPage(driver);
        [OneTimeSetUp]
        public void Init()
        {
            goPage.GoToHomePage();
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            driver.Quit();
        }


        [TearDown] 
        public void AfterTest()
        {
            Thread.Sleep(300);
        }

        // Tests.
        [Test, Order(1)]                  
        public void Login()
        {
            User user = TestUsersGenerator.GenerateValidUser();
            LoginFunctions loginFunc = new LoginFunctions(driver);

            loginFunc.Login(user);

            LoginPage loginPage = new LoginPage(driver);

            Thread.Sleep(300); 
            Assert.IsTrue(loginPage.IsLoginPerformedSucceslly(), "Login is failed.");
        }

        [TestCaseSource(typeof(PostGenerator), "ValidPost"), Order(2)]
        public void NewPost(string title, string url, string body)
        {
            Post post = new Post(title, url, body);
            PostEditorPage postEditor = new PostEditorPage(driver);
            PostFunctions postFunc = new PostFunctions(driver);
            postFunc.Publish(post);
            goPage.GoToHomePage();
            Thread.Sleep(300);
            Assert.AreEqual(title, postEditor.getPostedTitle());
            Assert.AreEqual(body, postEditor.getPostedBody());
        }

        [Test]
        public void Logout()
        {
            MainPage logout = new MainPage(driver);
            LogoutFunction logoutFunc = new LogoutFunction(driver);
            logoutFunc.Logout();
            Assert.IsTrue(logout.IsLogoutPerformedSucceslly(), "Logout is failed.");
        } 
    }
}