using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.BinaryTrees
{
    /// <summary>
    /// A binary tree node - holds the Value and left and right pointers (references).
    /// </summary>
    /// <typeparam name="TNode"></typeparam>
    public class BinaryTreeNode<TNode> : IComparable<TNode> where TNode : IComparable<TNode>
    {
        #region Properties
        public BinaryTreeNode<TNode> Left { get; set; }
        public BinaryTreeNode<TNode> Right { get; set; }
        public TNode Value { get; set; }
        #endregion Properties

        #region Constructor
        public BinaryTreeNode(TNode value)
        {
            Value = value;
        }
        #endregion Constructor
        
        #region IComparable Interface
        /// <summary>
        /// Compares the current node's Value to the provided Value
        /// </summary>
        /// <param name="other">The node value to compare to</param>
        /// <returns>1 if the instance value is greater than the provided value, -1 if less or 0 if equal.</returns>
        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }
        #endregion IComparable Interface
    }
}
