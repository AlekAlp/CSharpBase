using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    class BodyMassIndex
    {        
        public static double CalcBodyMassIndex(double weight, double height)
        {
            height = height / 100; // Перевод см в метры
            return (weight / (height * height));
        }
    }
}

