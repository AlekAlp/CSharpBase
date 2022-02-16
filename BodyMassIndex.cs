using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class BodyMassIndex
    {
        const double MIN_NORMAL_INDEX = 18.5f;
        const double MAX_NORMAL_INDEX = 25;
        public static void MassIndex(double height, double weight)
        {
            double result;
            result = Formula(height, weight);

            if (result >= MIN_NORMAL_INDEX && MAX_NORMAL_INDEX >= result)
                Console.WriteLine("Вы идеальны");
            else if(MIN_NORMAL_INDEX > result)
            {
                Console.Write("Вам стоит поправиться на ");
                double target = 0;
                for (double correction = 0.5f; Formula(height, weight) < MIN_NORMAL_INDEX;)
                {
                    target = target + correction;
                    weight = weight + correction;
                }
                Console.WriteLine($"{target} кг");
            }
            else if (MAX_NORMAL_INDEX < result)
            {
                Console.Write("Вам стоит сбросить ");
                double target = 0;
                for (double correction = 0.5f; Formula(height, weight) > MAX_NORMAL_INDEX;)
                {
                    target = target + correction;
                    weight = weight - correction;
                }
                Console.WriteLine($"{target} кг");
            }
        }

        private static double Formula(double height, double weight)
        {
            return (weight / (height * height));
        }
    }
}
