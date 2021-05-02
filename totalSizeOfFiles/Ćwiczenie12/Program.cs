using System;
using System.IO;

namespace Ćwiczenie12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ścieżkę do wybranego katalogu: ");
            string directoryPath = Console.ReadLine();

            DirectoryInfo dinfo = new DirectoryInfo(directoryPath);

            long filesSize = 0;

            FileInfo[] allfiles = dinfo.GetFiles();
            foreach (FileInfo finfo in allfiles)
            {
                filesSize = filesSize + finfo.Length;
            }

            Console.WriteLine($"Sumaryczna wartość plików w katalogu {directoryPath} wynosi: {filesSize} bajtów.");
        }
    }
}
