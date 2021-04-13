using System;

namespace Ćwiczenie8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj wartość parametru a: ");
                double a = Convert.ToDouble(Console.ReadLine());

                if (a == 0)
                {
                    throw new Exception("Parametr a nie może być równy 0.");
                }

                Console.WriteLine("Podaj wartość parametru b: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj wartość parametru c: ");
                double c = Convert.ToDouble(Console.ReadLine());

                double delta = b * b - 4 * a * c;
                double x1, x2;

                if (delta > 0)
                {
                    x1 = ((-b) - Math.Sqrt(delta)) / (2 * a);
                    x2 = ((-b) + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Równanie ma dwa pierwiastki rzeczywiste: x1={0} i x2={1}.", x1, x2);
                }
                else if (delta == 0)
                {
                    x1 = (-b) / (2 * a);
                    Console.WriteLine("Równanie ma jeden pierwiastek rzeczywisty: x={0}.", x1);
                }
                else
                {
                    Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Program nie może obliczyć delty. {0}", ex.Message);
            }
        }
    }
}
