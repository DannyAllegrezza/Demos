using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.HashTables
{
    public class FirstDuplicate
    {
        /*
        Given an array a that contains only numbers in the range from 1 to a.length, find the first duplicate number for which the second occurrence has the minimal index. In other words, if there are more than 1 duplicated numbers, return the number for which the second occurrence has a smaller index than the second occurrence of the other number does. If there are no such elements, return -1.
         */
        public static int FirstDupe(int[] arr){
            if (arr.Length <= 1){
                return -1;
            }

            var duplicateLookup = new int[arr.Length];

            var duplicateTable = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (duplicateTable.ContainsKey(arr[i])){
                    duplicateTable[arr[i]] += 1;
                }
                else{
                    duplicateTable.Add(arr[i], 1);
                } 

                if (duplicateTable[arr[i]] == 2){
                    return arr[i];
                }
            }

            return -1;
        }

        public static int FirstDupeArray(int[] a)
        {
            {
                // create lookup using new array 
                var seen = new int[a.Length];
                for (var i = 0; i < a.Length; i++)
                {
                    if (seen[a[i] - 1] != 0)
                    {
                        return a[i];
                    }

                    seen[a[i] - 1] = 1;
                }

                return -1;
            }
        }
    }
}
