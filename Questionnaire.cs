using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    class Questionnaire
    {
        public string Name;
        public string Surname;
        public int Age;
        public int Height;
        public int Weight;

        public static int TryParse(string value)
        {            
            try
            {                
                return Int32.Parse(value);
            }
            catch (FormatException)
            {
                return 0;
            }
            catch (OverflowException)
            {
                return 0;
            }
            catch (ArgumentException)
            {
                return 0;
            }            
        }

        public static string[] Question(string[] dataName)
        {
            string[] answer = dataName;
            for (int i = 0; i < dataName.Length; i++)
            {
                Console.Write($"{dataName[i]}: ");
                answer[i] = Console.ReadLine();
            }
            return answer;
        }
        public static void ShowDataWithGluing(string[] data)
        {
            string gluing = "";
            for (int i = 0; i < data.Length; i++)
            {
                if (i == 0)
                    gluing += ($"{data[i]}");
                else
                    gluing += ($", {data[i]}");
            }
            Console.WriteLine(gluing);
            Console.WriteLine();
        }

        public static void ShowData(string[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (i == data.Length - 1)
                    Console.Write($"{data[i]}");
                else
                    Console.Write($"{data[i]}, ");
            }
            Console.WriteLine();
        }
    }
}
