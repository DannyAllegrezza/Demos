using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.Queues;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void TestEnqueueFunctionality()
        {
            var myQueue = new Queues.Queue<int>();

            for (int i = 1; i <= 10; i++)
            {
                myQueue.Enqueue(i);
            }

            Assert.IsTrue(myQueue.Count > 0);
            Assert.AreEqual(10, myQueue.Count);

        }

        [TestMethod]
        public void TestDequeueFunctionality()
        {
            var myQueue = new Queues.Queue<int>();

            for (int i = 1; i <= 10; i++)
            {
                myQueue.Enqueue(i);
            }

            Assert.IsTrue(myQueue.Count > 0);
            Assert.AreEqual(10, myQueue.Count);

            // Verify items are dequeued in the correct order
            for (int i = 1; i <= 10; i++)
            {
                int item = myQueue.Dequeue();
                Assert.AreEqual(i, item);
            }
        }
    }
}
