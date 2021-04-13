using System;

namespace Ćwiczenie9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź ciąg liczb całkowitych oddzielonych od siebie przecinkami");
            string str = Console.ReadLine();
            string [] tabStr = str.Split(",");
            int[] tabInt = Array.ConvertAll(tabStr, int.Parse);

            Console.WriteLine("Liczby pierwsze z podanego ciągu to:");
            foreach (int x in tabInt)
            {
                if (x==2 | x==3)
                {
                    Console.Write(x + " ");
                }
                else if (x > 3)
                {
                    for (int i = 2; i*i <= x; i++)
                    {
                        if (x % i == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write(x + " ");
                            break;
                        }  
                    }
                }
            }        
        }
    }
}
