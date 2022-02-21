using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fractions frac1 = new Fractions(1, 2); // числа для демонстрации работы
            Fractions frac2 = new Fractions(3, 7);

            int enter = -1;
            while (enter != 0)
            {
                Console.Clear();
                Console.WriteLine("1 - сложение дроби");                
                Console.WriteLine("2 - вычетание дробей");
                Console.WriteLine("3 - умножение дробей");
                Console.WriteLine("4 - деление дробей");
                Console.WriteLine("5 - запустить цикл для сложения нечётных положительных чисел");
                Console.WriteLine("0 - выход");
                enter = ParseClass.ParseInt();
                switch (enter)
                {
                    case 1: 
                        Console.WriteLine(Math.Round(Fractions.PlusFractions(frac1, frac2), 2));
                        break;
                    case 2:
                        Console.WriteLine(Math.Round(Fractions.MinusFractions(frac1, frac2), 2));
                        break;
                    case 3:
                        Console.WriteLine(Math.Round(Fractions.MultiplyFractions(frac1, frac2), 2));
                        break;
                    case 4:
                        Console.WriteLine(Math.Round(Fractions.DivideFractions(frac1, frac2), 2));
                        break;
                    case 5:
                        Console.WriteLine(PositiveNumber.SumPositiveNumber());
                        break;
                    default:
                        break;
                }
                Console.WriteLine("нажмите Enter");
                Console.ReadLine();
            }                        
        }
    }
}
