using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.Stacks;

namespace DataStructures.Tests.Stacks
{
    [TestClass]
    public class StackTests
    {
        #region StackArray Tests
        /// <summary>
        /// Verify the Pop() functionality of my Stack class by creating 100 elements, then popping them off
        /// </summary>
        [TestMethod]
        public void TestStackArrayPop()
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 1; i <= 100; i++)
            {
                stack.Push(i);
            }

            // verify the top item on the stack when popping
            for (int i = 100; i <= 1; i--)
            {
                Assert.AreEqual(i, stack.Pop());
            }
            stack.Clear();

            Assert.AreEqual(0, stack.Count);
        }

        /// <summary>
        /// Verify items are pushing onto the Stack appropriately 
        /// </summary>
        [TestMethod]
        public void TestStackArrayPush()
        {
            Stack<int> stack = new Stack<int>();
            int count = 1;
            for (int i = 1; i <= 100; i++)
            {
                stack.Push(i);
                Assert.IsTrue(stack.Count == count);
                count++;
            }
        }
        #endregion StackArray Tests


    }
}
