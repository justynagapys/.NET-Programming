using System;
using System.Linq;

namespace Ćwiczenie4
{
    class Program
    {
        static void Main(string[] args)
        {
            przeciazenieKonstruktorów pk = new przeciazenieKonstruktorów();
            pk.metodaKonstruktory(123.0);
            pk.metodaKonstruktory('x');
            pk.metodaKonstruktory(123.0, 'x');
            pk.metodaKonstruktory(120, 52);
            pk.metodaKonstruktory(352);
        }
    }
    public class przeciazenieKonstruktorów
    {
        double liczba;
        char znak;

        public void metodaKonstruktory(double liczba)
        {
            this.liczba = liczba;
            Console.WriteLine(liczba);
        }
        public void metodaKonstruktory(char znak)
        {
            this.znak = znak;
            Console.WriteLine(znak);
        }
        public void metodaKonstruktory(double liczba, char znak)
        {
            this.liczba = liczba;
            this.znak = znak;
            Console.WriteLine(liczba + " " + znak);
        }
        public void metodaKonstruktory(int nwd1, int nwd2)
        {
            int x = nwd1;
            int y = nwd2;
            int wynik = 0;
            while (x != y)
            {
                if (x > y)
                {
                    wynik = x - y;
                    x = wynik;
                }
                else
                {
                    wynik = y - x;
                    y = wynik;
                }
            }

            Console.WriteLine("Największy wspólny dzielnik liczby: " + nwd1 + " i " + nwd2 + " to: " + wynik);
        }
        public void metodaKonstruktory(int rozmiar)
        {
            int i;
            int[] tablica = new int[rozmiar+1];
            for (i = 1; i <= rozmiar; i++)
            {
                tablica[i] = i; //inicjalizacja tablicy liczb pierwszych
            }
            for (i = 2; i <= (int)Math.Floor(Math.Sqrt(rozmiar)); i++)
            {
                if (tablica[i] != 0)
                {
                    int j = i + i;
                    while (j <= rozmiar)
                    {
                        tablica[j] = 0;
                        j += i;
                    }
                }
            }
            Console.WriteLine("Liczby pierwsze od 1 do " + rozmiar + ":");
            foreach (int x in tablica.Skip(2))
            {
                if (tablica[x] != 0)
                    Console.Write(x + " ");
            }
        }
    }
}

