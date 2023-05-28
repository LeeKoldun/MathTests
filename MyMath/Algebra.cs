using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public static class Algebra
    {
        public static double[] QuadEquationRoots(double a, double b, double c)
        {
            double d = (b * b) - 4 * a * c;

            if (d < 0)
                return null;

            if (d == 0)
                return new double[] { -b / (2 * a) };

            double root = Math.Sqrt(d);
            return new double[] 
            {
                (-b + root) / (2 * a), 
                (-b - root) / (2 * a) 
            };
        }

        public static double LineEquationRoot(double a, double b, double c) => (c - b) / a;

        public static double ArraySum(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            return sum;
        }

        public static double? ArrayMax(double[] arr)
        {
            if (arr.Length == 0)
                return null;

            if (arr.Length == 1)
                return arr[0];

            double max = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];

            return max;
        }

        public static double ArrayAvg(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            return sum / arr.Length;
        }
    }
}
