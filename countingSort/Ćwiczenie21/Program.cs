using System;
using System.Collections;

namespace Ćwiczenie21
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList alist = new ArrayList();
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                int number = random.Next(51);
                alist.Insert(i, number);
            }

            Console.WriteLine("Liczby do posortowania: ");
            foreach (var item in alist)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Liczby posortowane przez Counting Sort: ");
            countingSort(alist);
        }

        static public void countingSort(ArrayList list)
        {
            int[] sortedList = new int[list.Count];
            int[] count = new int[100];

            for (int i = 0; i < list.Count; i++)
            {
                int value = (int)list[i];
                count[value]++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                count[i] = count[i] + count[i - 1];
            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                int value = (int)list[i];
                int position = count[value] - 1;
                sortedList[position] = value;

                count[value]--;
            }

            foreach (var item in sortedList)
            {
                Console.Write(item + " ");
            }
        }
    }
}
