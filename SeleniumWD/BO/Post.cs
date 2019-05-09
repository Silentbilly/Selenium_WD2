using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWD.BO
{
    class Post
    {
        private string title;
        private string url;
        private string body;

        public Post(string title, string url, string body)
        {
            this.title = title;
            this.url = url;
            this.body = body;
        }
        public string GetTitle()
        {
            return title;   
        }
        public string GetUrl()
        {
            return url;
        }
        public string GetBody()
        {
            return body;
        }
    }
}
