using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class InsertionSort
    {
        /**
            More Info: https://visualgo.net/en/sorting?slide=8
         */
        public static int[] Sort(int[] unsortedArray)
        {
            int temp, j;

            // Make one outer pass
            for (int i = 1; i < unsortedArray.Length; i++)
            {
                temp = unsortedArray[i];
                j = i - 1;

                while (j >= 0 && unsortedArray[j] > temp)
                {
                    unsortedArray[j + 1] = unsortedArray[j];
                    j--;
                }

                unsortedArray[j + 1] = temp;
            }

            return unsortedArray;
        }
    }
}
