using System;

namespace Ćwiczenie7
{
    class Program
    {
        static void Main(string[] args)
        {
            //szyf Cezara - przesunięcie o 1 znak
            do
            {
                Console.WriteLine("Wprowadź tekst do zaszyfrowania (składający się wyłącznie z małych liter):");
                string str = Console.ReadLine();
                int[] tabInt = new int[str.Length];

                for (int i = 0; i < str.Length; i++)
                {
                    tabInt[i] = Convert.ToInt32(str[i]);
                    if (tabInt[i] >= 97 | tabInt[i] <= 122)
                    {
                        tabInt[i] = ((tabInt[i] - 96) % 26) + 97; 
                        //96 -> kod pierwszego znaku minus przesunięcie
                        //26 -> kod ostatniego znaku minus wcześniejszy wynik (96)
                        //97 -> stały kod pierwszego znaku
                        Console.Write(Convert.ToChar(tabInt[i]));
                    }
                }
                Console.WriteLine();
            } while (Console.ReadKey().Key != ConsoleKey.Escape);           
        }    
    }
}
