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
    class PostEditorPage : BasePage
    {
        public PostEditorPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
        [FindsBy(How = How.XPath, Using = ".//a[@class='panel-container__newPost']")]
        private IWebElement newPostButton;
        [FindsBy(How = How.XPath, Using = ".//*[@class = 'post-edit__title']/input")]
        private IWebElement titleField;
        [FindsBy(How = How.XPath, Using = ".//*[@class = 'post-edit__url']/input")]
        private IWebElement urlField;
        [FindsBy(How = How.XPath, Using = ".//textarea")]
        private IWebElement bodyField;
        [FindsBy(How = How.XPath, Using = ".//form/input[@type = 'submit']")]
        private IWebElement publishButton;
        [FindsBy(How = How.XPath, Using = "(.//h2[@class='post-title'])[last()]")]
        private IWebElement postedTitleField;
        [FindsBy(How = How.XPath, Using = "(.//div[@class='post-text'])[last()]")]
        private IWebElement postedBodyField;
        public PostEditorPage CreatePost()
        {
            newPostButton.Click();
            return this;
        }
        public PostEditorPage SetTitle(string title)
        {
            titleField.SendKeys(title);
            return this;
        }
        public PostEditorPage SetUrl(string url)
        {
            urlField.SendKeys(url);
            return this;
        }
        public PostEditorPage SetBody(string body)
        {
            bodyField.SendKeys(body);
            return this;    
        }
        public PostEditorPage PublishPost()
        {
            publishButton.Click();
            return this;
        }

        public void Publish(string title, string url, string body)
        {
            CreatePost()
                .SetTitle(title)
                .SetUrl(url)
                .SetBody(body)
                .PublishPost();
        }

        public String getPostedBody()
        {
            return postedBodyField.Text;
        }
        public String getPostedTitle()
        {
            return postedTitleField.Text;
        }
    }
}