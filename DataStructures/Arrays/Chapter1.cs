using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays
{
    public class Chapter1
    {
        /// <summary>
        /// Checks to see if a string contains only unique characters
        /// 
        /// <info>Time Complexity: O(n) Space Complexity: O(1)</info>
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool HasUniqueCharacters(string s)
        {
            // ASCI has 128 characters max so if we are greater than that, we can return false
            if (s.Length > 128)
            {
                return false;
            }

            // Create a boolean array that will be our lookup table
            var charLookup = new bool[128];

            for (int i = 0; i < s.Length; i++)
            {
                int val = s[i];
                if (charLookup[val] == true) // already found the character
                {
                    return false; 
                }
                charLookup[val] = true;
            }
            return true;
        }
    }
}
