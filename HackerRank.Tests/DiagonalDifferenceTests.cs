using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.Tests
{
    [TestClass]
    public class DiagonalDifferenceTests
    {
        [TestMethod]
        public void TestFindDiagonalDifference()
        {
            int[][] jaggedArray2 = new int[3][]
            {
                new int[] {11,2,4},
                new int[] {4,5,6},
                new int[] {10,8,-12}
            };

            int sdSum, pdSum;
            sdSum = pdSum = 0;
            
            for (int i = 0, j = jaggedArray2.GetLength(0)- 1; i < jaggedArray2.GetLength(0); i++, j--)
            {
                pdSum += jaggedArray2[i][i];
                sdSum += jaggedArray2[i][j];
            }

            Assert.AreEqual(15, Math.Abs(pdSum - sdSum));
        }
    }
}
