using System;
using System.Text;

namespace Ćwiczenie17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wyrażenie do kompresji: ");
            string[] text = Console.ReadLine().Split(' ');

            Console.WriteLine("Wyrażenie po dekompresji: ");

            int counter = 1;
            foreach (var word in text)
            {
                var RLEWord = new StringBuilder();
                char prevLetter = word[0];
                foreach (var i in word.Substring(1))
                {
                    if (i!=prevLetter)
                    {
                        addToRLE(RLEWord, counter, prevLetter);
                        counter = 0;
                    }
                    counter++;
                    prevLetter = i;
                }
                addToRLE(RLEWord, counter, prevLetter);
                Console.Write(RLEWord.ToString());
                Console.Write(" ");
            }
        }
        public static void addToRLE(StringBuilder RLEWord, int counter, char letter)
        {
            if (counter == 1)
                RLEWord.Append(letter);
            else
                RLEWord.Append($"{counter}{letter}");
        }
    }
}

