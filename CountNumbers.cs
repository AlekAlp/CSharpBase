using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class CountNumbers
    {
        public static void ResultEnterNumber()
        {
            int enterNumber = ParseClass.ParseInt();

            Console.WriteLine(Counting(enterNumber));
            Console.ReadLine();
        }
        public static int Counting(int enterNumber)
        {
            int count = 0;
            do
            {                
                enterNumber = enterNumber / 10;
                count++;                
            } while (enterNumber > 0);
            return count;
        }
    }
}
