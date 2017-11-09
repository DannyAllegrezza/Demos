using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IC.Tests.Stacks
{
    [TestClass]
    public class MaxStackTests
    {
        [TestMethod]
        public void TestFindMaxStack()
        {
            MaxStack stack = new MaxStack();
            stack.Push(100);
            stack.Push(101);
            stack.Push(102);
            stack.Push(103);
            stack.Push(1000);
            stack.Pop();
            stack.Pop();
            stack.Pop();

            int max = stack.GetMax();
            Assert.AreEqual(101, max);
        }
    }

    /// <summary>
    /// https://www.interviewcake.com/question/csharp/largest-stack
    /// </summary>
    public class MaxStack 
    {
        private HashSet<int> _set = new HashSet<int>();
        private Stack<int> _stack = new Stack<int>();

        public MaxStack()
        {

        }

        public int Pop()
        {
            int result;

            if (!_stack.TryPop(out result))
            {
                throw new Exception("No items to pop");
            }

            _set.Remove(result);

            return result;
        }

        public void Push(int item)
        {
            _set.Add(item);
            _stack.Push(item);
        }

        public int GetMax()
        {
            return _set.Max();
        }
    }
}