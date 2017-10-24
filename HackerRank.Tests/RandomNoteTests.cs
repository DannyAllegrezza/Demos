using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
/*
 * A kidnapper wrote a ransom note but is worried it will be traced back to him. 
 * He found a magazine and wants to know if he can cut out whole words from it and use them to create an untraceable replica of his ransom note. 
 * The words in his note are case-sensitive and he must use whole words available in the magazine, meaning he cannot use substrings or concatenation to create the words he needs.
 * 
 * Given the words in the magazine and the words in the ransom note, print Yes if he can replicate his ransom note exactly using whole words from the magazine; otherwise, print No
*/
namespace HackerRank.Tests
{
    [TestClass]
    public class RandomNoteTests
    {
        [TestMethod]
        public void CanCreateRansomNote()
        {
            string[] magazineWords = new string[] { "two", "times", "three", "is", "not", "four" };
            string[] ransomWords = new string[] { "two", "times", "two", "is", "four" };

            var magazineDictionary = new Dictionary<string, bool>();

            foreach (var word in magazineWords)
            {
                magazineDictionary.Add(word, false);
            }

            string result = "Yes";
            foreach (var word in ransomWords)
            {
                if (magazineDictionary.ContainsKey(word))
                {
                    if (magazineDictionary[word] == true)
                    {
                        result = "No";
                        break;
                    }
                    magazineDictionary[word] = true;
                }
                else
                {
                    result = "No";
                    break;
                }
            }
            Assert.AreEqual("No", result);

        }

        [TestMethod]
        public void RansomNoteIsNotValid()
        {
            string[] magazineWords = new string[] { "two", "times", "three", "is", "not", "four" };
            string[] ransomWords = new string[] { "two", "times", "two", "is", "four" };

            var result = IsRansomNote.IsValid(magazineWords, ransomWords);
            Assert.AreEqual("No", result);
        }
    }
}
