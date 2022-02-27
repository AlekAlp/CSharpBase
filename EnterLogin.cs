using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class EnterLogin
    {       
        public static bool CheckLogin(string login)
        {
            if ((login.Length >= 2) && (login.Length <= 10))
                if (!Char.IsNumber(login[0]))
                {
                    for (int i = 0; i < login.Length; i++)
                    {
                        if ((login[i] >= 'а') && (login[i] <= 'я') ||
                            (login[i] >= 'А') && (login[i] <= 'Я'))
                            return false;
                    }
                    return true;
                }
            return false;
        }
    }
}
