using System;

namespace Ćwiczenie5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 0;
            try
            {
                int wynik = a / b;
                Console.WriteLine(wynik);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("ArithmeticException: " + e.ToString());
            }
            try
            {
                int wynik = a / b;
                Console.WriteLine(wynik);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.ToString());
            }
            
        }
    }
}
