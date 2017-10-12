using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    /**
     * Bubble Sort is probably the simplest swapped algorithm to implement.
     * 
     * Worst Case Performance: O(n2)
     * Average Case Performance: O(n2)
     * Best Case performance: O(n)
     * Given an array of N elements, Bubble Sort will:
     * 1. Compare a pair of adjacent items (a, b),
     * 2. Swap that pair if the items are out of order (in this case a > b),
     * 3. Repeat Step 1 and 2 until we reach the end of array
        (the last pair is the (N-2)-th and (N-1)-th items as we use 0-based indexing),
     * 4. By now, the largest item will be at the last position.
        We then reduce N by 1 and repeat Step 1 until we have N = 1.

        More Info: https://visualgo.net/en/sorting?slide=6
     */
    public class BubbleSort
    {
        public static int[] Sort(int[] unsortedArray)
        {
            bool swapped = false;

            do
            {
                for (int i = 1; i < unsortedArray.Length - 1; i++)
                {
                    swapped = false;
                    int leftElement = unsortedArray[i - 1];
                    int rightElement = unsortedArray[i];
                    if (rightElement < leftElement)
                    {
                        // swap
                        int tmp = rightElement;
                        unsortedArray[i] = leftElement;
                        unsortedArray[i-1] = tmp;
                        swapped = true;
                    }
                }
            } while (swapped);

            return unsortedArray;
        }
    }
}
