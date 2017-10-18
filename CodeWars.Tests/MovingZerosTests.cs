using CodeWars._5kyu;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars.Tests
{


    [TestClass]
    public class MovingZerosTests
    {
        [TestMethod]
        public void TestMovingZerosToTheEnd()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, MovingZerosToTheEnd.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));

        }
    }
}
