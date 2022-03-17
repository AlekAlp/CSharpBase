using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Homework6
{
    delegate double MyFuncWithTwoNumber(double x, double a);
    delegate void MyPrint(double x, double y);

    class Program
    {
        static void Table(double a, double b, double step, MyFuncWithTwoNumber f, MyPrint p)
        {
            double x = a;
            double y = 0;
            while (x <= b)
            {
                y = f(x, b);
                p(x, y);
                x += step;
            }
        }
        public static double FunctionMultiply(double x, double a) => x * x * a;
        public static double FunctionMultiplyWithSin(double x, double a) => a * Math.Sin(x);
        static void Print(double x, double y)
        {
            Console.WriteLine("{0,10}{1,10}", x, y);
        }
        delegate double MinimalFunction(double firstParam);
        public static double Function(double x) => x * x - 50 * x + 10;        
        public static void SaveFunc(string fileName, double min, double max, double step)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            MinimalFunction newMinimalFunc;

            double x = min;
            newMinimalFunc = Function;
            while (x <= max)
            {
                
                bw.Write(newMinimalFunc(x));
                x += step;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        static void Main(string[] args)
        {
            MyFuncWithTwoNumber func1 = FunctionMultiply;
            MyFuncWithTwoNumber func2 = FunctionMultiplyWithSin;
            MyPrint p1 = Print;
            Table(0, 5, 1, func1, p1);
            Table(0, 5, 1, func2, p1);

            SaveFunc("data.bin", -100, 100, 0.5);
            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();
        }
    }
}
