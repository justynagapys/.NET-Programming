using System;

namespace Ćwiczenie18
{
    class Program
    {
        static void Main(string[] args)
        {
            CNumbers number = new CNumbers();

            Console.WriteLine("Podaj wartość liczby A: ");
            number.a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj wartość liczby B: ");
            number.b = Convert.ToInt32(Console.ReadLine());

            int NWW = number.a * number.b;
            for (int i = 1; i <= NWW; i++)
            {
                if (number.a % i == 0 && number.b % i == 0)
                    NWW = number.a * number.b / i;
            }
            Console.WriteLine($"Wartość NWW dla liczb {number.a} i {number.b} wynosi {NWW}");
        }
    }

    public interface INumbers
    {
        int a
        {
            get;
            set;
        }

        int b
        {
            get;
            set;
        }
    }

    public class CNumbers : INumbers
    {
        private int aClass, bClass;
        public int a
        {
            get
            {
                return aClass;
            }
            set
            {
                aClass = value;
            }
        }
        public int b
        {
            get
            {
                return bClass;
            }
            set
            {
                bClass = value;
            }
        }
    }
}
