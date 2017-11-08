using System;
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

        [TestMethod]
        public void IsValidBSTPrintInOrder()
        {
            var bstree = new Node(10);
            bstree.Insert(15);
            bstree.Insert(5);
            bstree.Insert(4);
            bstree.Insert(9);

            bstree.PrintInOrder();
        }

        [TestMethod]
        public void FindSecondLargestElementInBinaryTreeIsValid()
        {
            var bstree = new Node(10);
            bstree.Insert(15);
            bstree.Insert(5);
            bstree.Insert(4);
            bstree.Insert(9);

            var secondLargestNode = FindSecondLargest(bstree);

            Assert.AreEqual(10, secondLargestNode);

        }

        private int FindSecondLargest(Node rootNode)
        {
            var current = rootNode;

            while (true)
            {
                // Case: Current node is the largest and has a left subtree, so
                // the 2nd largest node is the largest in *that* subtree
                if (current.left != null && current.right == null)
                {
                    return FindLargest(current.left);
                }

                // Case: Current node is the parent of the largest node, and the largest has no children, so
                // the current is the 2nd largest value
                if (current.right != null
                    && current.right.left == null
                    && current.right.right == null)
                {
                    return current.data;
                }
                current = current.right;
            }
        }

        private int FindLargest(Node rootNode)
        {
            var current = rootNode;

            while (current.right != null)
            {                
                current = current.right;
            }

            return current.data;

        }
    }
}
