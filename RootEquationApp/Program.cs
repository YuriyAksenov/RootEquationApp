using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RootEquation;
using System.Threading;

namespace RootEquationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Action action1 = () =>
           {
               var result = Equation.HalfDivisionMethod((x) =>
               {
                   Thread.Sleep(1000);
                   return (x * x);
               }, -0.5, 0.5);

               Console.WriteLine("1 action =" + Math.Round(result, 5));
           };

            Action action2 = () =>
            {
                var result = Equation.HalfDivisionMethod((x) =>
                {
                    Thread.Sleep(10);
                    return (x * x);
                }, -0.5, 0.5);

                Console.WriteLine("2 action =" + Math.Round(result, 5));
            };

            Action action3 = () =>
            {
                var result = Equation.HalfDivisionMethod((x) =>
                {
                    Thread.Sleep(500);
                    return (x * x);
                    //return 4 * (Math.Pow(x, 2) + 1) * Math.Log(x) - 1;
                }, -0.5, 0.5);

                Console.WriteLine("3 action =" + Math.Round(result, 5));
            };

            var asyncResult1 = action1.BeginInvoke(null,null);

            var asyncResult2 = action2.BeginInvoke(null, null);

            var asyncResult3 = action3.BeginInvoke(null, null);

            action1.EndInvoke(asyncResult1);

            action2.EndInvoke(asyncResult2);

            action3.EndInvoke(asyncResult3);
        }
    }
}
