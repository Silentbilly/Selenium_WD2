using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWD.BO
{
    class TestUsersGenerator
    {
        public static User GenerateValidUser()
        {
            return new User("admin", "admin");
        }
    }
}