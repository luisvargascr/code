using Algorithms.SortingAlgorithms.Insertion;
using Algorithms.SortingAlgorithms.Selection;
using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] UnsortedArray1 = new int[] { 7, 8, 5, 4, 9, 2 };
            int[] UnsortedArray2 = new int[] { 7, 8, 5, 4, 9, 2 };

            var Selection = new SelectionSort();
            var SortedArray1 = Selection.Sort(UnsortedArray1);
            var Insertion = new InsertionSort();
            var SortedArray2 = Insertion.Sort(UnsortedArray2);

            Console.WriteLine("Selection Sort Algorithm:");
            foreach (int num in SortedArray1)
                Console.WriteLine(num.ToString());

            Console.WriteLine("------------------------");

            Console.WriteLine("Insertion Sort Algorithm:");
            foreach (int num in SortedArray2)
                Console.WriteLine(num.ToString());

            Console.ReadLine();
        }
    }
}
