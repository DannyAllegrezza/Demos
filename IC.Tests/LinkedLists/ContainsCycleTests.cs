using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace IC.Tests.LinkedLists
{
    [TestClass]
    public class ContainsCycleTests
    {
        [TestMethod]
        public void TestContainsCycleIsValid()
        {
            LinkedListNode head = new LinkedListNode(2);
            head.Next = new LinkedListNode(5);
            head.Next.Next = new LinkedListNode(6);
            head.Next.Next.Next = head;

            var expected = true;
            var actual = LinkedListNode.ContainsCycle(head);

            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void TestContainsCycleOptimizedIsValid()
        {
            LinkedListNode head = new LinkedListNode(2);
            head.Next = new LinkedListNode(5);
            head.Next.Next = new LinkedListNode(6);
            head.Next.Next.Next = head;

            var expected = true;
            var actual = LinkedListNode.ContainsCycleOptimized(head);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestReverseLinkedList()
        {
            LinkedListNode head = new LinkedListNode(2);
            head.Next = new LinkedListNode(3);
            head.Next.Next = new LinkedListNode(4);

            var result = LinkedListNode.ReverseLinkedList(head);

            int expectedValue = 4;

            while (result != null)
            {
                Assert.AreEqual(expectedValue, result.Value);
                expectedValue--;
                result = result.Next;
            }
        }

        [TestMethod]
        public void TestKthToLastNodeIsValid()
        {
            var a = new LinkedListNode(1);
            var b = new LinkedListNode(2);
            var c = new LinkedListNode(3);
            var d = new LinkedListNode(4);
            var e = new LinkedListNode(5);

            a.Next = b;
            b.Next = c;
            c.Next = d;
            d.Next = e;

            // Returns the node with value 4 (the 2nd to last node)
            var node = LinkedListNode.KthToLastNode(2, a);
        }
    }
}
