using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DataStructures.Tests
{
    [TestClass]
    public class Chapter1
    {
        [TestMethod]
        public void TestHasUniqueCharactersWithHashTable()
        {
            Assert.AreEqual(true, DataStructures.HashTables.Chapter1.HasUniqueCharacters("true"));
            Assert.AreEqual(false, DataStructures.HashTables.Chapter1.HasUniqueCharacters("falsee"));
        }

        [TestMethod]
        public void TestHasUniqueCharactersWithArray()
        {
            Assert.AreEqual(true, Arrays.Chapter1.HasUniqueCharacters("true"));
            Assert.AreEqual(false, Arrays.Chapter1.HasUniqueCharacters("falsee"));
        }

        [TestMethod]
        public void TestReplaceSpacesInString()
        {
            var word = Arrays.Chapter1.ReplaceAllSpaces(new char[] { 'M', 'r', ' ', 'J', 'o', 'h', 'n', ' ', 'S', 'm', 'i', 't', 'h', ' ', ' ', ' ', ' ', ' ' }, 13);
        }

        [TestMethod]
        public void TestCompressString()
        {
            //var bad = Arrays.Chapter1.CompressStringBad("aabcccccaaa");
            Assert.AreEqual("a2b1c5a3", Arrays.Chapter1.CompressString("aabcccccaaa"));

            Assert.AreEqual("a2b1c5a3d1", Arrays.Chapter1.CompressString("aabcccccaaad"));

            Assert.AreEqual("abcdefg", Arrays.Chapter1.CompressString("abcdefg"));


        }

        [TestMethod]
        public void TestMoveZeros()
        {
            var actual = Arrays.Chapter1.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });
            var expected = new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 };

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(actual[i], expected[i]);
            }
        }

        [TestMethod]
        public void TestTheWaveIsValidWhenInputIsEmpty()
        {
            var expected = new List<string> { };
            var result = Arrays.Chapter1.Wave("");

            Assert.AreEqual(expected.Count, result.Count);
        }

        [TestMethod]
        public void TestTheWaveIsValid()
        {
            var result = Arrays.Chapter1.Wave("dan");
        }
    }
}
