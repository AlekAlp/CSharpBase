using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    class PointClass
    {
        public static void EnterPoint()
        {
            Point pointA = new Point(1,2); //случайные значения
            Point pointB = new Point(5,8);
            double result = Formula(pointA, pointB);
            Console.WriteLine(Math.Round(result, 2));
        }


        public static double Formula(Point firstPoint, Point secondPoint)
        {
            return Math.Sqrt(Math.Pow(secondPoint.firstCoordinate - firstPoint.firstCoordinate, 2) + Math.Pow(secondPoint.secondCoordinate - firstPoint.secondCoordinate, 2));
        }
    }
}
