using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
