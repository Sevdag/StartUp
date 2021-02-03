using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp
{
    class LoginPage
    {
        public string UserName = "sevdag";
        public string Password = "Sg1234";
        

        public LoginPage(string EnteredUserName, string EnteredPassword)
        {
            if (EnteredUserName==UserName&& EnteredPassword==Password)
            {
                Console.WriteLine("Login succesfull");
            }
            else
            {

                Console.WriteLine("Username or Password is not coreect");
            }
        }
    }
}
