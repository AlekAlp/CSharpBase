using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class ParseClass
    {
        public static int ParseInt()
        {            
            try
            {
                return Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Info.WrongDataInfo();
                return 0;
            }
            catch (OverflowException)
            {
                Info.WrongDataInfo();
                return 0;
            }
        }

        public static double ParseDouble()
        {
            try
            {
                return double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Info.WrongDataInfo();
                return 0;
            }
            catch (OverflowException)
            {
                Info.WrongDataInfo();
                return 0;
            }
        }
    }
}
