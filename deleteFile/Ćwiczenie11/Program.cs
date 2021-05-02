using System;
using System.IO;

namespace Ćwiczenie11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Co chcesz usunąć? folder czy plik?");
            string whatToDelete = Console.ReadLine();

            if (whatToDelete == "folder")
            {
                Console.WriteLine("Podaj ścieżkę do folderu, który chcesz usunąć: ");
                string DirectoryToDelete = Console.ReadLine();

                DirectoryInfo dinfo = new DirectoryInfo(DirectoryToDelete);

                Console.WriteLine("Czy na pewno chcesz usunąć ten folder? Tak/nie");
                if (Console.ReadLine() == "tak")
                {
                    dinfo.Delete();
                    Console.WriteLine("Okej. Folder został usunięty.");
                }
                else if (Console.ReadLine() == "nie")
                {
                    Console.WriteLine("Okej. Folder pozostał bez zmian.");
                } else {
                    Console.WriteLine("Nieprawidłowa komenda. Spróbuj ponownie.");
                }
            }
            else if (whatToDelete == "plik")
            {
                Console.WriteLine("Podaj ścieżkę do pliku, który chcesz usunąć: ");
                string FileToDelete = Console.ReadLine();

                FileInfo finfo = new FileInfo(FileToDelete);

                Console.WriteLine("Czy na pewno chcesz usunąć ten plik? Tak/nie");
                if (Console.ReadLine() == "tak")
                {
                    finfo.Delete();
                    Console.WriteLine("Okej. Plik został usunięty.");
                }
                else if (Console.ReadLine() == "nie")
                {
                    Console.WriteLine("Okej. Plik pozostał bez zmian.");
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa komenda. Spróbuj ponownie.");
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowa komenda. Spróbuj ponownie.");
            }
  

            
        }
    }
}
