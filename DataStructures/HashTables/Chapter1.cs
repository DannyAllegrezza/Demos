using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.HashTables
{
    public class Chapter1
    {
        // Question 1 - Page 73
        public static bool HasUniqueCharacters(string s)
        {
            s = s.ToUpper();
            var uniqueChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            Dictionary<char, bool> alphabetLookup = new Dictionary<char, bool>();

            foreach (var c in uniqueChars)
            {
                alphabetLookup.Add(c, false);
            }

            // Solve the problem!
            foreach (char c in s)
            {
                if (alphabetLookup[c] == true)
                {
                    return false;
                }
                else
                {
                    alphabetLookup[c] = true;
                }
            }

            return true;
        }
    }
}
