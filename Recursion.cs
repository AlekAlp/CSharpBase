using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Recursion
    {
        public static void Recursive(int a, int b)
        {
            if (a <= b)
            {
                Console.Write($"{a} ");
                a++;
                Recursive(a, b);
            }
            else
            {
                Console.WriteLine();
                return;
            }
        }
        public static void SumRecursive(int a, int b, int result = 0)
        {
            if (a <= b)
            {
                result = result + a;
                a++;
                SumRecursive(a, b, result);
            }
            else
            {
                Console.WriteLine(result);
                return;
            }
        }
    }
}
