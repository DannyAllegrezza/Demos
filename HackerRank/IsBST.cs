using System;
using System.Collections.Generic;

namespace HackerRank
{
    /// <summary>
    /// One approach to check if a Tree is a binary tree or just a standard tree. 
    /// https://www.hackerrank.com/challenges/ctci-is-binary-search-tree/problem
    /// </summary>
    public class IsThisABST
    {
        public static bool IsBSTUtil(Node node, int min, int max)
        {
            // empty tree is still a BST
            if (node == null)
                return true;

            // false if this Node violates the min/max constraints
            if (node.data < min || node.data > max)
            {
                return false;
            }

            // otherwise, check the subtrees recursively, tightening the min/max constraints
            return (IsBSTUtil(node.left, min, node.data - 1) &&
                    IsBSTUtil(node.right, node.data + 1, max));
        }

        public static bool IsBST(Node node)
        {
            return IsBSTUtil(node, Int32.MinValue, Int32.MaxValue);
        }
    }

    public class Node
    {
        public Node left, right;
        public int data;
        public Node(int data)
        {
            this.data = data;
        }

        public void Insert(int value)
        {
            if (value <= data)
            {
                // adding to left
                if (left == null)
                {
                    left = new Node(value);
                }
                else
                {
                    left.Insert(value);
                }
            }
            else
            {
                if (right == null)
                {
                    right = new Node(value);
                }
                else
                {
                    right.Insert(value);
                }
            }
        }

        public bool Contains(int value)
        {
            if (value == data)
            {
                return true;
            }
            if (value < data)
            {
                // should be on the left side
                if (left == null)
                {
                    return false;
                }
                else
                {
                    return left.Contains(value);
                }
            }
            else
            {
                if (right == null)
                {
                    return false;
                }
                else
                {
                    return right.Contains(value);
                }
            }
        }

        // Prints Left, Middle, Right
        public void PrintInOrder()
        {
            if (left != null)
            {
                left.PrintInOrder();
            }
            Console.Write($"{data} ");
            if (right != null)
            {
                right.PrintInOrder();
            }
        }

        // Prints Middle, Left, Right
        public void PrintPreOrder()
        {
            Console.Write($"{data} ");
            if (left != null)
            {
                left.PrintPreOrder();
            }
            if (right != null)
            {
                right.PrintPreOrder();
            }
        }

        // Print Left, Right, Middle
        public void PrintPostOrder()
        {
            if (left != null)
            {
                left.PrintPostOrder();
            }
            if (right != null)
            {
                right.PrintPostOrder();
            }
            Console.Write($"{data} ");
        }
    }
}
