using System;

namespace Ćwiczenie6
{
    class Program
    {
        static void Main(string[] args)
        {
            bubbleSort bb = new bubbleSort();
            int[] tab = new int[10];
            Console.WriteLine("Podaj swoją tablicę 10 liczb do posortowania");
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    tab[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Nieposortowana tablica: ");
                foreach (int x in tab)
                    Console.Write(x + " ");
                Console.WriteLine();
                bb.bubbleSorting(tab, 10);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Nieprawidłowy format danych: " + e.ToString());
            }
        }
    }
    class bubbleSort
    {
        public void bubbleSorting(int[] tab, int n)
        {
            int tmp;
            for (int j = 0; j <= n - 2; j++)
            {
                for (int i = 0; i <= n - 2; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        tmp = tab[i + 1];
                        tab[i + 1] = tab[i];
                        tab[i] = tmp;
                    }
                }
            }
            Console.WriteLine("Posortowana tablica sortowaniem bąbelkowym: ");
            foreach (int x in tab)
                Console.Write(x + " ");
        }
    }
}
