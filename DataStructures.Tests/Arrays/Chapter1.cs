using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DataStructures.Tests
{
    [TestClass]
    public class Chapter1Tests
    {
        [TestMethod]
        public void TestFirstNotRepeatingCharacter()
        {            
            Assert.AreEqual('c', Arrays.Chapter1.FirstNotRepeatingCharacter("abacabad"));
            Assert.AreEqual('_', Arrays.Chapter1.FirstNotRepeatingCharacter("aa"));
            Assert.AreEqual('g', Arrays.Chapter1.FirstNotRepeatingCharacter("ngrhhqbhnsipkcoqjyviikvxbxyphsnjpdxkhtadltsuxbfbrkof"));
        }

        [TestMethod]
        public void TestFindDuplicatesContainsDupe(){
            Assert.AreEqual(3, HashTables.FirstDuplicate.FirstDupe(new int[]{2, 3, 3, 1, 5, 2}));
            Assert.AreEqual(3, HashTables.FirstDuplicate.FirstDupeArray(new int[] { 2, 3, 3, 1, 5, 2 }));
        }
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
        public void TestRotateImage()
        {

        }

        [TestMethod]
        public void TestReplaceSpacesInString()
        {
            var word = Arrays.Chapter1.ReplaceAllSpaces(new char[] { 'M', 'r', ' ', 'J', 'o', 'h', 'n', ' ', 'S', 'm', 'i', 't', 'h', ' ', ' ', ' ', ' ', ' ' }, 13);
        }

        [TestMethod]
        public void TestCompressString()
        {
            Assert.AreEqual("a2b1c5a3", Arrays.Chapter1.CompressString("aabcccccaaa"));
            Assert.AreEqual("a2b1c5a3d1", Arrays.Chapter1.CompressString("aabcccccaaad"));
            Assert.AreEqual("abcdefg", Arrays.Chapter1.CompressString("abcdefg"));
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
