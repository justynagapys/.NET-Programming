using System;

namespace Ćwiczenie19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź ciąg 9 liczb całkowitych oddzielonych od siebie przecinkami");
            string str = Console.ReadLine();
            string[] tabStr = str.Split(",");
            int[] tabInt = Array.ConvertAll(tabStr, int.Parse);

            int n = 9;
            insertSort(tabInt, n);

            Console.WriteLine("Posortowana tablica sortowaniem przez wstawianie: ");
            foreach (var item in tabInt)
            {
                Console.Write(item + " ");
            }
        }

        public static void insertSort<T>(T[] tab, int n) where T : IComparable
        {
            for (int i = 2; i < n; i++)
            {
                T buffor = tab[i];
                int j = i - 1;

                while (j >= 0 && tab[j].CompareTo(buffor) > 0)
                {
                    tab[j + 1] = tab[j];
                    j -= 1;
                }
                tab[j + 1] = buffor;
            }
        }
    }
}
