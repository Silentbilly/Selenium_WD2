using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWD.BO
{
    class User
    {
        private string login;
        private string password;
        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
        
        public string getLogin()
        {
            return login;
        }

        public string getPassword()
        {
            return password;
        }
    }
}
