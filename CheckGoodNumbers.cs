using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class CheckGoodNumbers
    {
        public static void CheckCycle(int data = 1000000000)
        {
            DateTime startMoment = DateTime.Now;            
            int countGoodNumbers = 0;
            for (int i = 1; i < data; i++)
            {
                if (i % CountNumbers.Counting(i) == 0)
                    countGoodNumbers++;                
            }
            DateTime finishMoment = DateTime.Now;
            Console.WriteLine($"В числе {data} - {countGoodNumbers} хороших чисел");
            Console.WriteLine($"прошло {finishMoment.Minute - startMoment.Minute} минут {finishMoment.Second - startMoment.Second} секунд");

            Console.ReadLine();
        }
    }
}
