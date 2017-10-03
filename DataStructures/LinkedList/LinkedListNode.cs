using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    /// <summary>
    ///  A node in the LinkedList class. Uses generics to hold any type of object.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedListNode<T>
    {
        /// <summary>
        /// The node value
        /// </summary>
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }

        #region Constructor
        public LinkedListNode(T value)
        {
            Value = value;
        }
        #endregion

    }
}
