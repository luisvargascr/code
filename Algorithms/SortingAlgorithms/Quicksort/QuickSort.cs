using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SortingAlgorithms.Quicksort
{
    public class QuickSort
    {
        public void Sort(int[] array)
        {
            QuickSortMethod(array, 0, array.Length - 1);

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
        private void QuickSortMethod(int[] array, int left, int right)
        {
            if (left >= right)
                return;

            int pivot = array[(left + right) / 2];
            int index = partition(array, left, right, pivot);
            QuickSortMethod(array, left, index - 1);
            QuickSortMethod(array, index, right);
        }
        private int partition(int[] array, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (array[left] < pivot)
                    left++;

                while (array[right] > pivot)
                    right--;

                if (left <= right)
                {
                    Swap(array, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }
        private void Swap (int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
