using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Authorization
    {       
        public static bool CheckAuthorization(string path)
        {
            string[] account = new string[2];
            Account adminAccount = new Account("root", "GeekBrains");
            try
            {
                account = File.ReadAllLines(path);
                if (account[0] == adminAccount.Login) 
                    if (account[1] == adminAccount.Password)
                        return true;
                    return false;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public struct Account
        {
            public Account(string login, string password)
            {
                Login = login;
                Password = password;
            }

            public string Login { get; }
            public string Password { get; }

        }
    }
}
