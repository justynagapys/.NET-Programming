using System;

namespace Ćwiczenie20
{
    class Program
    {
        static void Main(string[] args)
        {
            Outside.Inside ins = new Outside.Inside();
            ins.newtonRaphsonAlgorithm(3);
            ins.newtonRaphsonAlgorithm(5);
            ins.newtonRaphsonAlgorithm(37);
        }
    }

    public class Outside
    {
        public class Inside
        {
            public void newtonRaphsonAlgorithm(double number)
            {
                double epsilon = 0.000001;

                double x = number;

                double result;

                int i = 0;

                while (true)
                {
                    i++;
                    result = 0.5 * (x + (number / x));
                    if (Math.Abs(result - x) < epsilon)
                        break;
                    x = result;
                }

                Console.WriteLine("Wartość wyliczona z algorytmu Newtona-Raphsona dla pierwiastka z liczby " + number + " wynosi " + result);
            }
        }
    }
}
