using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Fractions
    {
        private int numerator;

        public int numeratorProperty
        {
            get { return numerator; }
            set { numerator = value; }
        }
        private int denominator;

        public int denominatorProperty
        {
            get { return denominator; }
            set { denominator = value; }
        }
        private double fraction;
        public Fractions(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            this.fraction = (double)numerator / (double)denominator;
        }

        public static double PlusFractions(Fractions frac1, Fractions frac2)
        {
            return frac1.fraction + frac2.fraction;
        }

        public static double MinusFractions(Fractions frac1, Fractions frac2)
        {
            return frac1.fraction - frac2.fraction;
        }

        public static double MultiplyFractions(Fractions frac1, Fractions frac2)
        {
            return frac1.fraction * frac2.fraction;
        }

        public static double DivideFractions(Fractions frac1, Fractions frac2)
        {
            try
            {
                return frac1.fraction / frac2.fraction;
            }
            catch (ArgumentException)
            {                
                Console.WriteLine("Нельзя делить на 0");
                return 0;
            }
        }



    }
}
