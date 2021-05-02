using System;
using System.IO;

namespace Ćwiczenie10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj nazwę katalogu do utworzenia:");
            string directoryName = Console.ReadLine();
            Console.WriteLine("Podaj nazwę pliku do utworzenia:");
            string fileName = Console.ReadLine();
            Console.WriteLine("Wprowadź ciąg 10 liczb całkowitych oddzielonych od siebie przecinkami:");
            string str = Console.ReadLine();
            string[] tabStr = str.Split(",");
            int[] tabInt = Array.ConvertAll(tabStr, int.Parse);

            DirectoryInfo dinfo = new DirectoryInfo("C:\\Users\\justy\\source\\repos\\Ćwiczenie10");
            DirectoryInfo subdinfo = dinfo.CreateSubdirectory(directoryName);

            FileInfo finfo = new FileInfo(subdinfo + "\\" + fileName + ".txt");
            FileStream fstream = finfo.Create();

            Quicksort(tabInt, 0, tabInt.Length - 1);

            using (var swriter = new StreamWriter(fstream))
            {
                swriter.WriteLine("Ciąg 10 liczb przed sortowaniem: " + string.Join(" ", tabStr));            
                swriter.Write("Ciąg 10 liczb po sortowaniu algorytmem quicksort: " + string.Join(" ", Array.ConvertAll(tabInt, x => x.ToString())));

            }
            fstream.Close();

            Console.WriteLine("Katalog i plik został utworzony, a ciąg liczb został posortowany.");
        }

        private static void Quicksort(int[] arrayOfNumbers, int leftSide, int rightSide)
        {
            int i = leftSide;
            int j = rightSide;

            var pivot = arrayOfNumbers[(leftSide + rightSide) / 2];

            while (i <= j)
            {
                while (arrayOfNumbers[i] < pivot)
                    i++;
                while (arrayOfNumbers[j] > pivot)
                    j--;
                if (i <= j)
                {
                    var temp = arrayOfNumbers[i];
                    arrayOfNumbers[i] = arrayOfNumbers[j];
                    arrayOfNumbers[j] = temp;
                    i++;
                    j--;
                }
            }
            if (leftSide < j)
                Quicksort(arrayOfNumbers, leftSide, j);
            if (i < rightSide)
                Quicksort(arrayOfNumbers, i, rightSide);
        }
    }
}
