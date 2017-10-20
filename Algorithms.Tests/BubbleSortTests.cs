using Algorithms.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Tests
{
    [TestClass]
    public class BubbleSortTests
    {
        [TestMethod]
        public void TestBubbleSort()
        {
            var unsortedArray = new int[]{3, 7, 4, 4, 6, 5, 8};
            var sortedArray = new int[] { 3, 4, 4, 5, 6, 7, 8 };

            unsortedArray = BubbleSort.Sort(unsortedArray);

            var result = BubbleSort.Sort(new int[] { 3, 2, 1 });
            Assert.IsTrue(sortedArray.SequenceEqual(unsortedArray));

        }
    }
}
