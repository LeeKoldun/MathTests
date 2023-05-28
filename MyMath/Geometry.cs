using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    static public class Geometry
    {
        public static double RectangelArea(double a, double b) => a * b;

        public static double TriangleArea(double a, double b, double c)
        {
            double p = (a * b * c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static double RightTriangleArea(double a, double b) => 0.5 * a * b;

        public static double CircleArea(double r) => 3.14 * (r * r);

        public static double TrapeziodArea(double a, double b, double h) => (a * b / 2) * h;
    }
}
