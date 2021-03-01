using System;

namespace Ćwiczenie1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i > 0; i--)
            {
                if (i % 3 == 0)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            int j = 100;
            while (j > 0)
            {
                if (j % 3 == 0)
                {
                    if (j % 2 == 1)
                    {
                        Console.WriteLine(j);
                    }
                }
                j--;
            }
            int k = 100;
            do
            {
                if (k % 3 == 0)
                {
                    if (k % 2 == 1)
                    {
                        Console.WriteLine(k);
                    }
                }
                k--;
            } while (k > 0);
        }
    }
}
