using System;
using System.IO;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstMassive = StaticClass.MassiveRandom();

            firstMassive = StaticClass.CheckFileMassive();            
            WriteInConsole(firstMassive);
            Console.WriteLine("Количество пар: ");
            Console.WriteLine(StaticClass.VaultDivineThree(firstMassive)); 

            MassiveClass newMassiveClass = new MassiveClass(1);
            Console.WriteLine(newMassiveClass.SumProperty);

            int[] secondMassive = MassiveClass.Inverse(newMassiveClass);
            WriteInConsole(secondMassive);

            secondMassive = MassiveClass.Multiply(newMassiveClass, 10);
            WriteInConsole(secondMassive);


            if(Authorization.CheckAuthorization(@"D:\TestAuthorization.txt") == true)
                Console.WriteLine("Авторизация завершена");
            else
                Console.WriteLine("нет данных для входа");
        }

        public static void WriteInConsole(int[] massive)
        {
            for (int i = 0; i < massive.Length; i++)
            {
                Console.WriteLine(massive[i]);
            }
        }
        

    }
}
