using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SortingAlgorithms.Insertion
{
    public class InsertionSort
    {
        public int[] Sort (int[] list)
        {
            int i, j, key, temp = 0;

            for (i = 1; i < list.Length; i++)
            {
                Console.WriteLine("--------------------------------------");
                key = list[i];
                j = i - 1;
                Console.WriteLine(string.Format("i = {0}; j = {1}", i, j));
                PrintCurrentStatusOfArray(list,i,j);
                Console.WriteLine(string.Format("key {0} < j {1}", key, list[j]));
  
                while (j >= 0 && key < list[j])
                {
                    temp = list[j];
                    
                    list[j] = list[j + 1];
                    
                    list[j + 1] = temp;
                    Console.WriteLine(string.Format("Swap A[{0}] -->A[{1}] ", j, j + 1));
                    j--;
                }
            }
            return list;
        }

        private void PrintCurrentStatusOfArray(int[] list, int i, int j)
        {
            var List = string.Empty;
            int cnt1 = 0;
            int cnt2 = 0;

            foreach (int SingleNum in list)
            {
                if (cnt1 == i)
                {
                    List += "(" + SingleNum + ")";
                }
                else if (cnt2 == j)
                {
                    List += "[" + SingleNum + "]";
                }
                else
                {
                    List += SingleNum + ",";
                }
                List = List.TrimEnd();
                cnt1 += 1;
                cnt2 += 1;
            }
            Console.WriteLine(string.Format("A = {0}", List));
        }
    }
}
