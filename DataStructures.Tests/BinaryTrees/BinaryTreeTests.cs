using DataStructures.BinaryTrees;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.BinaryTrees
{
    [TestClass]
    public class BinaryTreeTests
    {
        [TestMethod]
        public void Enumerator_Of_Single()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            foreach (int item in tree)
            {
                Assert.Fail("An empty tree should not enumerate any values");
            }

            Assert.IsFalse(tree.Contains(10), "Tree should not contain 10 yet");

            tree.Add(10);

            Assert.IsTrue(tree.Contains(10), "Tree should contain 10");

            int count = 0;
            foreach (int item in tree)
            {
                count++;
                Assert.AreEqual(1, count, "There should be exactly one item");
                Assert.AreEqual(item, 10, "The item value should be 10");
            }
        }

        [TestMethod]
        public void InOrder_Enumerator()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            //        4
            //       / \
            //      2   5
            //     / \   \
            //    1   3   7
            //           / \
            //          6   8

            tree.Add(4);
            tree.Add(5);
            tree.Add(2);
            tree.Add(7);
            tree.Add(3);
            tree.Add(6);
            tree.Add(1);
            tree.Add(8);

            int[] expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            int index = 0;

            foreach (int actual in tree)
            {
                Assert.AreEqual(expected[index++], actual, "The item enumerated in the wrong order");
            }
        }


        [TestMethod]
        public void InOrder_Delegate()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            //        4
            //       / \
            //      2   5
            //     / \   \
            //    1   3   7
            //           / \
            //          6   8

            tree.Add(4);
            tree.Add(5);
            tree.Add(2);
            tree.Add(7);
            tree.Add(3);
            tree.Add(6);
            tree.Add(1);
            tree.Add(8);

            int[] expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            int index = 0;

            tree.InOrderTraversal(item => Assert.AreEqual(expected[index++], item, "The item enumerated in the wrong order"));
        }

        [TestMethod]
        public void PreOrder_Delegate()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            //        4
            //       / \
            //      2   5
            //     / \   \
            //    1   3   7
            //           / \
            //          6   8

            tree.Add(4);
            tree.Add(5);
            tree.Add(2);
            tree.Add(7);
            tree.Add(3);
            tree.Add(6);
            tree.Add(1);
            tree.Add(8);

            int[] expected = new[] { 4, 2, 1, 3, 5, 7, 6, 8 };

            int index = 0;

            tree.PreOrderTraversal(item => Assert.AreEqual(expected[index++], item, "The item enumerated in the wrong order"));
        }

        [TestMethod]
        public void PostOrder_Delegate()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            //        4
            //       / \
            //      2   5
            //     / \   \
            //    1   3   7
            //           / \
            //          6   8

            tree.Add(4);
            tree.Add(5);
            tree.Add(2);
            tree.Add(7);
            tree.Add(3);
            tree.Add(6);
            tree.Add(1);
            tree.Add(8);

            int[] expected = new[] { 1, 3, 2, 6, 8, 7, 5, 4 };

            int index = 0;

            tree.PostOrderTraversal(item => Assert.AreEqual(expected[index++], item, "The item enumerated in the wrong order"));
        }
    }
}
