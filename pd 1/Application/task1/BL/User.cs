using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.BL
{
    internal class User
    {
        public string username;
        public string userpassword;
        public string role;
        public User() 
        {

        }
        public User(string name,string password,string role)
        {
            this.username = name;
            this.userpassword = password;
            this.role= role;
        }
        public User(string name,string password)
        {
            this.username = name;
            this.userpassword = password;   
        }
        
    }
}
