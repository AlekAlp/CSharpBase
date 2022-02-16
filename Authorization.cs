using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Authorization
    {
        public static bool Check(string login, string password)
        {
            if (login == "root")
                if (password == "GeekBrains")
                    return true;

            return false;
        }

        public static void CheckCycle()
        {
            byte count = 3;
            do
            {
                count--;                
                Console.WriteLine("Логин: ");
                string login = Console.ReadLine();
                Console.WriteLine("Пароль: ");
                string password = Console.ReadLine();
                if (Check(login, password))
                {
                    Console.WriteLine("Авторизация завершена");
                    break;
                }
                Console.WriteLine($"Неверный логин/пароль; осталось попыток: {count}");
            } while (count > 0);
            Console.ReadLine();
        }
    }
}
