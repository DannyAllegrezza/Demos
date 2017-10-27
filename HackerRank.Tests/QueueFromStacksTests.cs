using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.QueueFromStack;
namespace HackerRank.Tests
{
    [TestClass]
    public class QueueFromStacksTests
    {
        Queue MyQueue { get; set; }
        [TestInitialize]
        public void Init()
        {
            MyQueue = new Queue();
            MyQueue.Enqueue(23334137);
            MyQueue.Enqueue(213585005);
            MyQueue.Enqueue(865236554);
            MyQueue.Enqueue(664450041);
            MyQueue.Enqueue(13658878);
            TestEnqueueIsValid();

            MyQueue.Dequeue();
            TestDequeueIsValid();
        }

        [TestMethod]
        public void TestEnqueueIsValid()
        {
            Assert.AreEqual(MyQueue.Count, 5);
        }

        [TestMethod]
        public void TestDequeueIsValid()
        {
            Assert.AreEqual(MyQueue.Count, 4);
        }    
    }
}
