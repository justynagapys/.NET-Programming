using System;

namespace Ćwiczenie3
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = 10;
            int[][] tab = new int[len][];
            int x = 0;
            int y = 1;
            for (int i = 0; i < len; i++)
            {
                tab[i] = new int[y];
                for (int j = 0; j < tab[i].Length; j++)
                {
                    tab[i][j] = tab[i].Length - j;
                }
                int z = x + y;
                x = y;
                y = z;
            }
            for (int i = 0; i < len; i++)
            {
                Console.Write($"tab[{i}] = ");
                for (int j = 0; j < tab[i].Length; j++)
                {
                    Console.Write(tab[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}