using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class SingleNumber
    {
        public static int Solution(int[] nums)
        {
            if (nums == null) return 0;
            if (nums.Length == 1) return nums[0];

            var lookupTable = new Dictionary<int, int>();

            for (int index = 0; index < nums.Length; index++)
            {
                int currentNumber = nums[index];

                if (!lookupTable.ContainsKey(currentNumber))
                {
                    lookupTable.Add(currentNumber, 1);
                }
                else
                {
                    lookupTable[currentNumber]++;
                }
            }

            return lookupTable.FirstOrDefault(x => x.Value == 1).Key;
        }
    }
}
