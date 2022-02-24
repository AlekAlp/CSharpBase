using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class StaticClass
    {
        public const string PATH = @"D:\MassiveOfFile.txt";
        public static int VaultDivineThree(int[] massive)
        {
            int result = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                if (i != massive.Length - 1)
                    if (((massive[i] % 3 == 0) && (massive[i + 1] % 3 != 0)) ||
                       ((massive[i] % 3 != 0) && (massive[i + 1] % 3 == 0)))
                    {
                        result++;
                    }
            }
            return result;
        }
        public static int[] MassiveRandom()
        {
            Random rnd = new Random();

            int[] massive = new int[20];
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = rnd.Next(-10000, 10000);
            }
            return massive;
        }

        public static int[] CheckFileMassive()
        {
            if (!File.Exists(PATH)) // если файла нет
            {
                int[] newMassive = MassiveRandom();
                string[] saveFileMassive = new string[newMassive.Length];
                for (int i = 0; i < newMassive.Length; i++)
                {
                    saveFileMassive[i] = Convert.ToString(newMassive[i]);

                }
                File.WriteAllLines(PATH, saveFileMassive);
                return newMassive;
            }
            else
            {
                int[] newMassive = new int[20];
                string[] newMassiveString = File.ReadAllLines(PATH);
                for (int i = 0; i < newMassiveString.Length; i++)
                {
                    try
                    {
                        newMassive[i] = Int32.Parse(newMassiveString[i]);
                    }
                    catch(FormatException)
                    {
                        newMassive[i] = 0;
                    }
                }
                return newMassive;
            }
        }
    }
}
