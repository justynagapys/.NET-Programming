using System;

namespace Ćwiczenie2
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = 4;
            int num = 10;
            int[][] tab = new int[len][];
            for (int i = 1; i <= len; i++)
            {
                tab[i - 1] = new int[i];
                for (int j = 1; j <= i; j++)
                {
                    tab[i - 1][j - 1] = num;
                    num--;
                    Console.Write(tab[i - 1][j - 1] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
