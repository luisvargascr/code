using Algorithms.SortingAlgorithms.Insertion;
using Algorithms.SortingAlgorithms.RadixSort;
using Algorithms.SortingAlgorithms.Selection;
using Algorithms.SortingAlgorithms.Quicksort;
using Algorithms.SortingAlgorithms.MergeSort;
using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] UnsortedArray1 = new int[] { 7, 8, 5, 4, 9, 2 };
            //int[] UnsortedArray2 = new int[] { 7, 8, 5, 4, 9, 2 };
            //int[] UnsortedArray3 = new int[] { 7, 8, 5, 4, 9, 2 };
            //int[] UnsortedArray4 = new int[] { 7, 8, 5, 4, 9, 2 };
            int[] UnsortedArray5 = new int[] { 19,13,1,3,23,5,4,73 };

            var MergeSort = new MergeSort();
            MergeSort.PrintArray(UnsortedArray5);
            MergeSort.Sort(UnsortedArray5);
            MergeSort.PrintArray(UnsortedArray5);
            Console.ReadLine();

            //var QuickSort = new QuickSort();
            //QuickSort.Sort(UnsortedArray4);

            //Console.ReadLine();

            //var Radix = new RadixSort();
            //Radix.Sort(UnsortedArray1);
            //Console.ReadLine();

            //var Selection = new SelectionSort();
            //var SortedArray1 = Selection.Sort(UnsortedArray1);
            //var Insertion = new InsertionSort();
            //var SortedArray2 = Insertion.Sort(UnsortedArray2);

            //Console.WriteLine("Selection Sort Algorithm:");
            //foreach (int num in SortedArray1)
            //    Console.WriteLine(num.ToString());

            //Console.WriteLine("------------------------");

            //Console.WriteLine("Insertion Sort Algorithm:");
            //foreach (int num in SortedArray2)
            //    Console.WriteLine(num.ToString());

            //Console.ReadLine();
        }
    }
}
