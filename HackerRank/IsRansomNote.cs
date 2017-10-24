using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class IsRansomNote
    {
        private const string NO = "No";
        private const string YES = "Yes";

        public static string IsValid(string[] magazine, string[] ransom)
        {
            if (ransom.Length > magazine.Length)
            {
                return NO;
            }

            var magazineDictionary = new Dictionary<string, bool>();

            // Store all magazine words in the dict so we can look them up quickly
            foreach (var word in magazine)
            {
                if (!magazineDictionary.ContainsKey(word))
                {
                    magazineDictionary.Add(word, false);
                } else
                {
                    return NO;
                }
            }

            foreach (var word in ransom)
            {
                if (magazineDictionary.ContainsKey(word))
                {
                    if (magazineDictionary[word] == true)
                    {
                        return NO;
                    }
                    magazineDictionary[word] = true;
                }
                else
                {
                    return NO;
                }
            }

            return YES;

        }
    }
}
