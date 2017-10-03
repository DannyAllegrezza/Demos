using DataStructures.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace DataStructures.Tests.LinkedList
{
    [TestClass]
    public class NodeTests
    {
        /// <summary>
        /// Shows how a simple node chain can be created and linked together.
        /// </summary>
        [TestMethod]
        public void CreateNodeChain()
        {
            Node head = new Node() { Value = 3 };
            Node middle = new Node() { Value = 5 };
            head.Next = middle;
            Node last = new Node() { Value = 7 };
            middle.Next = last;

            while (head != null)
            {
                Debug.WriteLine(head.Value);
                head = head.Next;
            }
        }
    }
}
