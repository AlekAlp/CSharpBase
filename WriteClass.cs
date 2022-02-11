using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    class WriteClass
    {
        public static void WriteData(string name, string surname, string city)
        {
            string centerText = $"{surname} {name}, {city}";
            int centerX = (Console.WindowWidth / 2) - (centerText.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.Write(centerText);
        }
    }
}
