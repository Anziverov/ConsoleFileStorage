using System.Configuration;
using System.Collections.Specialized;
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
            #region experimental
            MetaInformationKeeper metaInformationKeeper;
            #endregion
            if (args.Length == 0)
            {
                Authentication.GetCredentials();
                if (CLIListener.RegisterCurrentUser(Authentication.GetAccess()))
                {
                    metaInformationKeeper = new MetaInformationKeeper(ConfigurationManager.AppSettings.Get("pathToMeta"));
                    metaInformationKeeper.UploadFile(@"E:\\testFile.txt");
                    CLIListener.StartListen();
                }
            }
            else if(args.Length == 2)
            {
                Authentication.GetCredentials(args[0], args[1]);
                if (CLIListener.RegisterCurrentUser(Authentication.GetAccess()))
                {
                    metaInformationKeeper = new MetaInformationKeeper(ConfigurationManager.AppSettings.Get("pathToMeta"));
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
