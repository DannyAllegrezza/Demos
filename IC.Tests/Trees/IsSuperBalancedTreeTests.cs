using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace IC.Tests.Trees
{
    [TestClass]
    public class IsSuperBalancedTreeTests
    {
        [TestMethod]
        public void BinaryTreeIsNotSuperBalanced()
        {
            var root = new BinaryTreeNode(4);
            root.InsertLeft(3);
            root.InsertRight(5);
            var leftNode = root.Left;
            leftNode.InsertLeft(2);
            var leftLeftNode = leftNode;
            leftLeftNode.InsertLeft(1);
            leftNode = leftLeftNode.Left;
            leftNode.InsertLeft(2);

            var expected = false;

            var actual = BinaryTreeHelper.IsBalanced(root);

            Assert.AreEqual(expected, actual);
        }
    }

    public class BinaryTreeNode
    {
        public int Value { get; }

        public BinaryTreeNode Left { get; private set; }

        public BinaryTreeNode Right { get; private set; }

        public BinaryTreeNode(int value)
        {
            Value = value;
        }

        public BinaryTreeNode InsertLeft(int leftValue)
        {
            Left = new BinaryTreeNode(leftValue);
            return Left;
        }

        public BinaryTreeNode InsertRight(int rightValue)
        {
            Right = new BinaryTreeNode(rightValue);
            return Right;
        }
    }

    public class NodeDepthPair
    {
        public BinaryTreeNode Node {get;}
        public int Depth { get; }

        public NodeDepthPair(BinaryTreeNode node, int depth)
        {
            Node = node;
            Depth = depth;
        }
    }
    public class BinaryTreeHelper
    {
        public static bool IsBalanced(BinaryTreeNode treeRoot)
        {

            // a tree with no nodes is superbalanced, since there are no leaves!
            if (treeRoot == null)
            {
                return true;
            }

            var depths = new List<int>(3); // We short-circuit as soon as we find more than 2

            // Nodes will store pairs of a node and the node's depth
            var nodes = new Stack<NodeDepthPair>();
            nodes.Push(new NodeDepthPair(treeRoot, 0));

            while (nodes.Count > 0)
            {
                // Pop a node and its depth from the top of our stack
                var nodeDepthPair = nodes.Pop();
                var node = nodeDepthPair.Node;
                var depth = nodeDepthPair.Depth;

                // Case: we found a leaf
                if (node.Left == null && node.Right == null)
                {
                    // We only care if it's a new depth
                    if (!depths.Contains(depth))
                    {
                        depths.Add(depth);

                        // Two ways we might now have an unbalanced tree:
                        //   1) more than 2 different leaf depths
                        //   2) 2 leaf depths that are more than 1 apart
                        if (depths.Count > 2
                            || (depths.Count == 2 && Math.Abs(depths[0] - depths[1]) > 1))
                        {
                            return false;
                        }
                    }
                }

                // Case: this isn't a leaf - keep stepping down
                else
                {
                    if (node.Left != null)
                    {
                        nodes.Push(new NodeDepthPair(node.Left, depth + 1));
                    }

                    if (node.Right != null)
                    {
                        nodes.Push(new NodeDepthPair(node.Right, depth + 1));
                    }
                }
            }

            return true;
        }
    }
}
