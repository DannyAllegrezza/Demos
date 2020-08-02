using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests
{
    [TestClass]
    public class SingleNumberTests
    {
        [TestMethod]
        public void SingleNumber_WhenNullInput_Returns_0()
        {
            Assert.AreEqual(0, SingleNumber.Solution(null));
        }

        [TestMethod]
        public void SingleNumber_WhenGivenInputOfLength1_Returns_Expected()
        {
            Assert.AreEqual(25, SingleNumber.Solution(new int[] { 25 }));
        }

        [DataTestMethod]
        [DataRow(null, 0)]
        [DataRow(new int[] { 25 }, 25)]
        [DataRow(new int[] { 4, 1, 2, 1, 2 }, 4)]
        public void SingleNumber_WhenGivenInput_ReturnsExpectedResult(int[] input, int result)
        {
            var actual = SingleNumber.Solution(input);

            Assert.AreEqual(result, actual);
        }
    }
}
