using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RootEquation
{
    public static class Equation
    {
        public delegate double Function(double x);

        public static double HalfDivisionMethod(Function func, double startPosition, double endPosition, double accuracy  = 0.00001)
        {
            double middle = startPosition/2 + endPosition / 2;
            double valueStart = func(startPosition);
            double valueMiddle = func(middle);

            double d = valueStart * valueMiddle;

            if (d > 0)
            {
                startPosition = middle;
            }
            else endPosition = middle;

            double difference = Math.Abs(startPosition - endPosition);

            if (difference >= accuracy) return HalfDivisionMethod(func, startPosition, endPosition, accuracy);
            
            return startPosition/2+ endPosition / 2;
        }


    }
}
