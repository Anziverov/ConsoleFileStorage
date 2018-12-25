using System.Configuration;
using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFileStorage
{
    static class Authentication
    {
        static string login;
        static string password;
        public static void GetCredentials(string sLogin, string sPassword)
        {
            login = sLogin;
            password = sPassword;
        }
        public static void GetCredentials()
        {
            Console.WriteLine("Login?");
            login = Console.ReadLine();
            Console.WriteLine("Password?");
            password = Console.ReadLine();
        }
        public static string GetAccess()
        {
            if(password == ConfigurationManager.AppSettings.Get(login))
            {
                Console.WriteLine("Access granted");
                return login;
            }
            else
            {
                Console.WriteLine("Access denied");
                return "";
            }
        }
    }
}
