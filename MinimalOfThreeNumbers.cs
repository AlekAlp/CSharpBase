using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class MinimalOfThreeNumbers
    {

        public static void EnterData()
        {
            int result;
            try
            {
                result = MinimalThreeNumbers(Int32.Parse(Console.ReadLine()),
                                             Int32.Parse(Console.ReadLine()),
                                             Int32.Parse(Console.ReadLine()));
                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Info.WrongDataInfo();
                return;
            }
            catch (OverflowException)
            {
                Info.WrongDataInfo();
                return;
            }
        }
        public static int MinimalThreeNumbers(int firstNumber, int secondNumber, int thirdNumber)
        {            
            if (firstNumber < secondNumber)
            {
                if (firstNumber < thirdNumber)
                {
                    return firstNumber;
                }
                else
                {
                    return thirdNumber;
                }
            }
            else
            {
                if (secondNumber < thirdNumber)
                {
                    return secondNumber;
                }
                else
                {
                    return thirdNumber;
                }
            }
        }

    }
}
