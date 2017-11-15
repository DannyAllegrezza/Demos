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

        /// <summary>
        /// Reverses a sentence of words.
        /// ex: "hello my name is danny" => "danny is name my hello" 
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public static string ReverseSentenceInPlace(this string sentence)
        {
            if (sentence == null) { return ""; }

            Stack<string> decodedMessage = new Stack<string>();

            var words = sentence.Split(" ");
            foreach (var word in words)
            {
                decodedMessage.Push(word);
            }

            // pop them off and create new word
            StringBuilder finalMessage = new StringBuilder();
            foreach (var word in decodedMessage)
            {
                finalMessage.Append(word + " ");  
            }

            sentence = finalMessage.ToString().Trim();

            return sentence;
        }
    }
}