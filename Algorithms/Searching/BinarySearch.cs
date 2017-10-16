using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Searching
{
    /// <summary>
    /// A basic, generic implementation of Binary Search. 
    /// Type: Divide and conquer 
    /// Abstract: The idea of the algorithm is to divide and conquer, reducing the 
    /// search area by half each time, trying to find the target number.
    /// 
    /// Worst-case scenario: We have to divide a list of n elements in half repeatedly to  find
    /// the target element, either because the target element will be found at the end of the
    /// last division OR doesn't exist in the data-set at all.
    /// 
    /// Best-caase scenario: The target element is at the midpoint of the full array, so we 
    /// can stop looking immediately after we start!
    /// </summary>
    public class BinarySearch
    {
        public static int Find(int[] data, int target)
        {
            int start = 0;
            int end = data.Length - 1;

            do
            {
                // get the mid
                int mid = (start + end) / 2;
                // if the target is at the middle, stop
                if (data[mid] == target)
                {
                    return mid;
                }
                // otherwise, if the target is less than whats at the middle, repeat, changing the end point to be ONE left of middle
                else if (target < data[mid])
                {
                    end = mid - 1;
                } 
                // otherwise, if the target is greater than whats at the middle, repeat, changing the end point to be ONE right of middle
                else
                {
                    start = mid + 1;
                }
            }
            while (start <= end);
            // target not found
            return -1;
        }
    }
}
