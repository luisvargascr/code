using System;

namespace Algorithms.SortingAlgorithms.MergeSort
{
    public class MergeSort
    {
        public void Sort(int []array)
        {
            int Left = 0;
            int Right = (array.Length) / 2;
            int[] TmpArray = new int[array.Length];
            int Middle = array.Length / 2;
            int[] FirstHalf = new int[Middle];
            int[] SecondHalf = new int[Middle];

            for (int cnt = 0; cnt < Middle; cnt++)
                FirstHalf[cnt] = array[cnt];

            int i = 0;
            for (int cnt = Middle; cnt < array.Length; cnt++)
            {
                SecondHalf[i] = array[cnt];
                i++;
            }

            Sort(array, TmpArray, Left, Right);

            foreach (int x in array)
            {
                Console.WriteLine(x);
            }
        }
        private void Sort (int [] array, int[] tmpArray, int left, int right)
        {
            if (array.Length == 1)
                return;

            for (int x = 0; x < array.Length; x++)
            {
                if (array[left] >= tmpArray[x])
                {
                    int tmp = array[left];
                    tmpArray[x] = tmp;
                    array[left] = tmpArray[x];
                }
            }
            left++;

           
        }
    }
}
