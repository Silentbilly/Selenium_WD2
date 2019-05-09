using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWD.BO
{
    class PostGenerator
    {
        public static Post GenerateValidPost()
        {
            return new Post("Test", "http://localhost:3030/admin", "AbCDFG HIJkLMNOP QrStUvWxYz1234567890!@#%^&*()"); // & - ?
        }
        public static Post GenerateValidPost2()
        {
            return new Post("Test2", "http://localhost:3030/admin", "AbCDFG HIJkLMNOP QrStUvWxYz1234567890!@#");
        }
        public static Post GenerateValidPost3()
        {
            return new Post("Test3", "http://localhost:3030", "AbCDFG HIJkLMNOP");
        }
    }
}
