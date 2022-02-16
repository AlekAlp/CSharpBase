using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа");
            MinimalOfThreeNumbers.EnterData();

            Console.WriteLine("Введите число, чтобы подсчитать его количество цифр");
            CountNumbers.ResultEnterNumber();

            Authorization.CheckCycle();

            Console.WriteLine("Введите свой рост(см): ");
            double height = (ParseClass.ParseDouble() / 100);
            Console.WriteLine("Введите свой вес(кг): ");
            double weight = ParseClass.ParseDouble();
            BodyMassIndex.MassIndex(height, weight);
            Console.ReadLine();

            CheckGoodNumbers.CheckCycle();
            
            Recursion.Recursive(ParseClass.ParseInt(), ParseClass.ParseInt());

            Recursion.SumRecursive(ParseClass.ParseInt(), ParseClass.ParseInt());

            Console.ReadLine();
        }        
    }
}
