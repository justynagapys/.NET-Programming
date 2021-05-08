using System;

namespace Ćwiczenie16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę do rozłożenia: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write($"Czynniki pierwsze dla {number} to: ");
            int x = 2;
            int y = (int)Math.Sqrt(number);
            while (x <= y)
            {
                while ((number % x) == 0)
                {
                    number /= x;
                    y = (int)Math.Sqrt(number);
                    Console.Write(x + " ");
                }
                x++;
            }
            if (number > 1) Console.Write(number+ " ");
        }
    }
}
