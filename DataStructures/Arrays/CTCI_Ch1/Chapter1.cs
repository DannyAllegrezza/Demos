using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Arrays
{
    public class Chapter1
    {
        public static int[][] RotateImage(int[][] matrix)
        {
            int n = matrix[0].Length;

            for (int layer = 0; layer < n / 2; ++layer)
            {
                int first = layer;
                int last = n - 1 - layer;

                for (int i = first; i < last; ++i)
                {
                    int offset = i - first;
                    // save off the top
                    int top = matrix[first][i];
                    // left -> top
                    matrix[first][i] = matrix[last - offset][first];
                    // bottom -> left
                    matrix[last - offset][first] = matrix[last][last - offset];
                    // right -> bottom
                    matrix[last][last - offset] = matrix[i][last];
                    // top -> right
                    matrix[i][last] = top;
                }
            }
            return matrix;
        }
        /// <summary>
        /// https://codefights.com/interview-practice/task/uX5iLwhc6L5ckSyNC
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static char FirstNotRepeatingCharacter(string s)
        {
            // hold items in a jagged array
            // [0] - letter 
            // [1] - (-1 already seen | 0 - unseen | 1 - unique)
            // [3] - index of letter in array

            int[][] jagged = new int[26][];
            for (int i = 0; i < 26; i++)
            {
                jagged[i] = new int[2];
            }

            for (int i = 0; i < s.Length; i++)
            {
                // get the character 
                char letter = s[i];
                int lookupIndex = char.ToUpper(letter) - 65;
                // if we are unseen
                if (jagged[lookupIndex][0] == 0)
                {
                    jagged[lookupIndex][0] = 1; // mark as unique
                    jagged[lookupIndex][1] = i; // store index of char in original string
                } else
                {
                    jagged[lookupIndex][0] = -1; // mark is duplicate
                }
            }

            char match = '_';
            int idx = s.Length;
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    if (jagged[i][0] > 0)
                    {
                        // get the index of char from original string
                        var tmp = jagged[i][1];
                        if (tmp < idx)
                        {
                            match = s[jagged[i][1]];
                            idx = tmp;
                        }
                    }
                }
            }
            return match;
        }

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

        /// <summary>
        /// Write a method to replace all spaces in a word with '%20'. You may assume that the string has sufficient space at the end of the string to hold the additional chaaacters, and that
        /// you are given the "true" length of the string. 
        /// 
        /// EX: 
        /// INPUT: "Mr John Smith    ", 13
        /// OUTPUT: "Mr%20John%20Smith"
        /// </summary>
        /// <param name="word"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static char[] ReplaceAllSpaces(char[] word, int length)
        {
            int spaceCount = 0;
            int newLength;

            // Count the spaces in the string
            for (int i = 0; i < length; i++)
            {
                if (word[i] == ' ')
                {
                    spaceCount++;
                }
            }
            newLength = length + spaceCount * 2;
            word[newLength] = '\0';

            for (int i = length - 1; i >= 0; i--)
            {
                if (word[i] == ' ')
                {
                    word[newLength - 1] = '0';
                    word[newLength - 2] = '2';
                    word[newLength - 3] = '%';
                    newLength = newLength - 3;
                } else
                {
                    word[newLength - 1] = word[i];
                    newLength = newLength - 1;
                }
            }
            return word;
        }

        /// <summary>
        ///  Doesn't work because keys have to be unique
        /// </summary>
        /// <param name="characters"></param>
        /// <returns></returns>
        public static string CompressStringBad(string characters)
        {
            if (characters == null) return "";

            Dictionary<char, int> matchedChars = new Dictionary<char, int>();

            char last = characters[0];
            matchedChars.Add(last, 1);
            // [a | 1]

            for (int i = 1; i < characters.Length; i++)
            {
                var currentChar = characters[i];
                if (currentChar == last)
                {
                    matchedChars[currentChar] = matchedChars[currentChar] + 1;
                }
                else
                {
                    matchedChars.Add(currentChar, 1);
                    last = currentChar;
                }
            }
            return "";
        }

        public static string CompressString(string characters)
        {
            if (characters == null) return "";

            StringBuilder compressedStringBuilder = new StringBuilder();
            char currentChar = characters[0];
            int currentCharCount = 1;

            // walk through the tokens in the string
            for (int i = 1; i < characters.Length; i++)
            {
                if (currentChar == characters[i])
                {
                    currentCharCount++;
                }
                else
                {
                    // token does not match then append current combo and create new token
                    compressedStringBuilder.Append(currentChar);
                    compressedStringBuilder.Append(currentCharCount);
                    currentChar = characters[i];
                    currentCharCount = 1;
                }
            }
            compressedStringBuilder.Append(currentChar);
            compressedStringBuilder.Append(currentCharCount);

            string compressedString = compressedStringBuilder.ToString();

            // check the total length of the newly created string and the original, return smallest of two
            return (compressedString.Length < characters.Length) ? compressedString : characters;
        }

        public static int[] MoveZeroes(int[] arr)
        {
            if (arr.Length == 0)
            {
                return arr;
            }
            if (arr == null)
            {
                throw new NullReferenceException("Array cannot be null");
            }

            // Create a new array the size of the original array
            int[] newArray = new int[arr.Length];
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    newArray[count] = arr[i];
                    count++;
                }

            }
            // new fix the new array 
            return newArray;
        }

        /// <summary>
        /// A method that returns a list of strings to simulate the "wave".
        /// "dog" --> { "Dog", "dOg", "doG" }
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static List<string> Wave(string str)
        {
            var theWaveList = new List<string>();

            if (string.IsNullOrWhiteSpace(str)) { return theWaveList; }

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsWhiteSpace(str[i]))
                {
                    continue;
                }
                theWaveList.Add(AddToWave(str, i));
            }
            return theWaveList;
        }

        private static string AddToWave(string str, int i)
        {
            var strChars = str.ToCharArray();
            strChars[i] = Char.ToUpper(strChars[i]);
            return new string(strChars);
        }
    }
}
