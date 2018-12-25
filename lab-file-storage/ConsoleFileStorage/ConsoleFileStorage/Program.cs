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
           
            if(args.Length == 0)
            {
                Authentication.GetCredentials();
                if (CLIListener.RegisterCurrentUser(Authentication.GetAccess()))
                {
                    CLIListener.StartListen();
                }
            }
            else if(args.Length == 2)
            {
                Authentication.GetCredentials(args[0], args[1]);
                if (CLIListener.RegisterCurrentUser(Authentication.GetAccess()))
                {
                    CLIListener.StartListen();
                }
            }
            else
            {
                Console.WriteLine(args.Length + " arguments is incorrect number of initial arguments! Must be [login] [password]");
            }
            

        }
       
    }
}
