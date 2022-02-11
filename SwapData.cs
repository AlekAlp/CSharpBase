using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    class SwapData
    {
        public static void Swap(int a, int b)
        {
            (a, b) = (b, a);
            Console.WriteLine($"{a}, {b}");
        }
    }
}
