using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class PositiveNumber
    {
        public static int SumPositiveNumber()
        {
            int result = 0;
            int enterNumber = -1;
            Console.WriteLine("Вводятся числа; когда будет введён 0, подсчёт закончится");
            for (int i = 1; enterNumber != 0; i++)
            {
                Int32.TryParse(Console.ReadLine(), out enterNumber);
                if ((i % 2 != 0) && (enterNumber > 0))
                {
                    result = result + enterNumber;
                }
            }
            return result;
        }
    }
}
