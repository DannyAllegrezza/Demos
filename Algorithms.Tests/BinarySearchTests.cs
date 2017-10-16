using Algorithms.Searching;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void TestBinarySearchReturnsCorrectIndex()
        {
            var expected = 0;
            var index = BinarySearch.Find(new int[] {1,2,3,4,5,6 }, 1);

            Assert.AreEqual(expected, index);
        }

        [TestMethod]
        public void TestBinarySearchRetursnCorrectWhenValueNotFound()
        {
            var expected = -1;
            var index = BinarySearch.Find(new int[] { 1, 2, 3, 4, 5, 6 }, 122);

            Assert.AreEqual(expected, index);
        }
    }
}
