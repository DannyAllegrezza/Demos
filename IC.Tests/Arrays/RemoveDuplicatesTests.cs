using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IC.Tests.Arrays
{

    [TestClass]
    public class RemoveDuplicatesTests
    {
        [TestMethod]
        public void RemoveDuplicates_WhenGivenValidInput_ReturnsExpectedResult()
        {
            var result = RemoveDuplicates.Solution(new int[] { 1, 1, 2 });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void RemoveDuplicates_WhenGivenValidInputOf_0011122334_Returns_5()
        {
            var result = RemoveDuplicates.Solution(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
            Assert.AreEqual(5, result);
        }
    }

    /// <summary>
    /// Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.
    /// Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
    /// Example 1:
    /// Given nums = [1,1,2],
    /// Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively.
    /// It doesn't matter what you leave beyond the returned length.
    /// </summary>
    public class RemoveDuplicates
    {
        public static int Solution(int[] nums)
        {
            if (nums == null) return 0;
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return 1;

            int uniqueElements = 1;
            int lastUniqueNumber = nums[0];
            int positionOfLastUniqueNumber = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                int currentNumber = nums[i];

                if (currentNumber == lastUniqueNumber)
                {
                    continue;
                }

                uniqueElements++;
                lastUniqueNumber = currentNumber;
                nums[++positionOfLastUniqueNumber] = lastUniqueNumber;
            }

            return uniqueElements;
        }
    }
}
