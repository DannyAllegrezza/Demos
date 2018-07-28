using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._6kyu
{
    public class BalancedSymbols
    {
        /// <summary>
        /// This method will return whether or not a string contains a balanced set of symbols.
        /// {(())} == true
        /// [)] == false
        /// [{()}] == true
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsBalanced(string text)
        {
            if (text == null) return false;

            var lookup = new Dictionary<char, char>()
            {
                {'{', '}' },
                {'(', ')' },
                {'[', ']' }
            };

            Stack<char> openingChars = new Stack<char>();

            for (int index = 0; index < text.Length; index++)
            {
                var currentChar = text[index];

                if (lookup.ContainsKey(currentChar))
                {
                    // Add to our stack to keep track of all of the opening characters
                    openingChars.Push(currentChar);
                }
                else if (currentChar == ']' || currentChar == ')' || currentChar == '}')
                {
                    if (openingChars.Count == 0) { return false; }
                    // If we hit a closing character, pop off the stack and see if they are opposites.. if so, we are still balanced, otherwise
                    // we are unbalanced!
                    var poppedChar = openingChars.Pop();
                    var opposite = lookup[poppedChar];

                    if (currentChar != opposite)
                    {
                        return false;
                    }
                }
            }

            if (openingChars.Count > 0)
            {
                return false;
            }

            return true;
        }
    }
}
