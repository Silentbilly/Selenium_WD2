using OpenQA.Selenium;
using SeleniumWD.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWD.BusinessFunctions
{
    class PostFunctions
    {
        public IWebDriver driver;
        public PostFunctions(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Publish(Post post)
        {
            new PostEditorPage(driver).Publish(post.GetTitle(), post.GetUrl(), post.GetBody());
        }
    }
}
