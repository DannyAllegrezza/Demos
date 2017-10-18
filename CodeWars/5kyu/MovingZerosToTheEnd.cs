using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._5kyu
{
    public class MovingZerosToTheEnd
    {
        public static int[] MoveZeroes(int[] arr)
        {
            if (arr.Length == 0)
            {
                return arr;
            }
            if (arr == null)
            {
                //throw new NullReferenceException("Array cannot be null");
            }

            // Create a new array the size of the original array
            int[] newArray = new int[arr.Length]; // already padded with 0's
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    newArray[count] = arr[i];
                    count++;
                }
            }
            return newArray;
        }
    }
}
