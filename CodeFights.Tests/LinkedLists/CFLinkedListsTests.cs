using CodeFights.LinkedLists;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeFights.Tests
{
    [TestClass]
    public class CFLinkedListsTests
    {
        [TestMethod]
        public void TestRemoveKFromListIsValid()
        {
            ListNode<int> node = new ListNode<int>();
            node.Value = 3;
            var next = new ListNode<int>();
            next.Value = 1;
            node.Next = next;
            var next2 = new ListNode<int>();
            next2.Value = 2;
            next.Next = next2;
            var next3 = new ListNode<int>();
            next3.Value = 3;
            next2.Next = next3;

            ListNode<int> result = CFLinkedLists.RemoveKFromList(node, 3);

            while (result != null)
            {
                Assert.IsTrue(result.Value == 1);
                result = result.Next;
                Assert.IsTrue(result.Value == 2);
                result = result.Next;
            }
        }
    }
}
