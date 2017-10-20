using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.Tests
{
    [TestClass]
    public class IsBSTTest
    {
        [TestMethod]
        public void IsNotValidBST()
        {
            var bstree = new Node(10);
            bstree.Insert(15);
            bstree.Insert(5);
            bstree.Insert(4);
            bstree.Insert(9);
            // no longer a BST
            bstree.left.right.data = 2;

            var result = IsThisABST.IsBST(bstree);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IsValidBST()
        {
            var bstree = new Node(10);
            bstree.Insert(15);
            bstree.Insert(5);
            bstree.Insert(4);
            bstree.Insert(9);

            var result = IsThisABST.IsBST(bstree);

            Assert.AreEqual(true, result);
        }
    }
}
