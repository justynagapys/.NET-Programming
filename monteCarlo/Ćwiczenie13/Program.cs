using System;
using System.IO;

namespace Ćwiczenie13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj nazwę pliku do utworzenia:");
            string fileName = Console.ReadLine();

            FileInfo finfo = new FileInfo(fileName + ".txt");
            FileStream fstream = finfo.Create();

            using (var swriter = new StreamWriter(fstream))
            {
                swriter.WriteLine("Przybliżona wartość liczby PI metodą Monte Carlo wynosi: " + MonteCarlo());
            }
            fstream.Close();

            Console.WriteLine("Przybliżona wartość liczby PI metodą Monte Carlo została obliczona.");
        }

        private static double MonteCarlo()
        {
            double piNumber = 0;          
            long hits = 0;

            Random random = new Random();
            for (long i = 0; i < 100000000; ++i)
            {
                double x = random.NextDouble();
                double y = random.NextDouble();
                if (x * x + y * y < 1.0) 
                    hits++;
            }
            return piNumber = 4.0 * hits / 100000000;
        }
    }
}
