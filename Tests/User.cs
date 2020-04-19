using System;
using System.Collections.Generic;
using System.Text;

namespace baigiamasis.Tests
{
     public class User
    {
        public static User DefaultUser = new User("testeris@testas.lt", "slaptazodis");

        public string UserEmail;
        public string Password;

        public User(string user, string password)
        {
            UserEmail = user;
            Password = password;
        }
    }
}
