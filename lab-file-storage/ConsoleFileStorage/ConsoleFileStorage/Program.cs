using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFileStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            Authentication.GetCredentials();
            if (CLIListener.RegisterCurrentUser(Authentication.GetAccess()))
            {
                CLIListener.StartListen();
            }

        }
       
    }
}
