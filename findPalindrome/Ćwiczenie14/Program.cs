using System;
using System.IO;
using System.Linq;

namespace Ćwiczenie14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Znalezione palindromy: ");

            using (StreamReader sr = new StreamReader("C:\\Users\\justy\\source\\repos\\Ćwiczenie14\\palindromy.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Palindrom p = new Palindrom();
                    Console.WriteLine(p.findPalindrome(line)); 
                }
            }
        }
    }

    public class Palindrom
    {
        private string palindrom;
        public string findPalindrome(string fileLine)
        {
            string[] wordsTab = fileLine.Split(" ");
            foreach (var word in wordsTab)
            {
                char[] reverseWordArray = word.ToCharArray();
                Array.Reverse(reverseWordArray);
                string reverseWord = new string (reverseWordArray);
                if (reverseWord == word)
                {
                    palindrom = word;
                }
            }
            return palindrom;
        }
    }
}
