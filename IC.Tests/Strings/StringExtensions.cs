using System;
using System.Collections.Generic;
using System.Text;

namespace IC.Tests.Strings
{
    public static class StringExtensions
    {
        public static string ReverseStringInPlace(this string s)
        {
            if (s == null) { return ""; }

            char[] letters = s.ToCharArray();

            for (int head = 0, tail = (letters.Length - 1); head < tail; head++, tail--)
            {
                char tmp = letters[head];
                letters[head] = letters[tail];
                letters[tail] = tmp;
            }

            return new string(letters);
        }
    }
}
