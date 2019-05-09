using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWD.BO
{
    public static class PostGenerator
    {
        public static object[] DataTest = new object[]
        {
            new Post("Test", "http://localhost:3030/admin", "Test testing.")        
        };

    }
}
