using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFileStorage
{
    static class CLIListener
    {
        static string currentCommand = "";
        static string currentUser; // add separate user class
        public static bool RegisterCurrentUser(string userName)
        {
            if(userName != null && userName != "")
            {
                currentUser = userName;
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public static void StartListen()
        {
            while(currentCommand != "exit")
            {
                GetCommand();
                ProceedCommand();
            }
        }
        public static void GetCommand()
        {
            currentCommand = Console.ReadLine();
        }
        public static void ProceedCommand()
        {
            if(currentCommand == "user info")
            {
                GetUserInfo();
            }
            else if(currentCommand == "exit")
            {
                //some realsing here
            }
            else
            {
                Console.WriteLine("Wrong command");
            }
        }
        public static void GetUserInfo()
        {
            Console.WriteLine("User info:");
            Console.WriteLine("User login: " + currentUser);
        }
    }
}
