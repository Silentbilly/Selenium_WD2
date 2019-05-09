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
            User user = TestUsersGenerator.GenerateValidUser();
            LoginFunctions loginFunc = new LoginFunctions(driver);

            loginFunc.Login(user);

            LoginPage loginPage = new LoginPage(driver);

            Thread.Sleep(1000); 
            Assert.IsTrue(loginPage.isLoginPerformedSucceslly(), "Login is failed.");
        }

        [Test, Order(2)]
        public void NewPost()
        {
            Post post = PostGenerator.GenerateValidPost2();
            PostFunctions postFunc = new PostFunctions(driver);
            postFunc.Publish(post);

            PostEditorPage postEditor = new PostEditorPage(driver);
            driver.Url = "http://localhost:3030/admin";
            Thread.Sleep(300);
            Assert.AreEqual(post.GetTitle(), postEditor.getPostedTitle());   
            Assert.AreEqual(post.GetBody(), postEditor.getPostedBody());
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