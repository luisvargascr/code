using Algorithms.SortingAlgorithms.Selection;
using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var Selection = new SelectionSort();
            var SortedArray = Selection.Sort(new int[] { 7, 8, 5, 4, 9, 2 });

            foreach (int num in SortedArray)
                Console.WriteLine(num.ToString());

            Console.ReadLine();
        }
    }
}
