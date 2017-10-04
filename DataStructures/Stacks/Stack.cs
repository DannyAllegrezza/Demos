using System;
using System.Collections.Generic;
using System.Collections;

namespace DataStructures.Stacks
{
    /// <summary>
    /// Implementation of a Stack, backed by a LinkedList
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Stack<T> : IEnumerable<T>
    {
        private LinkedList<T> _list = new LinkedList<T>();

        /// <summary>
        /// Adds an item to the top of the Stack
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            _list.AddFirst(item);
        }

        /// <summary>
        /// Returns and removes the top most item on the Stack
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("No items on the Stack to Pop.");
            }

            T value = _list.First.Value;
            _list.RemoveFirst();

            return value;
        }

        /// <summary>
        /// Returns the top item from the Stack without removing it from the Stack
        /// </summary>
        /// <returns>The top-most item in the Stack</returns>
        public T Peek()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("No items on the Stack to Peek");
            }

            return _list.First.Value;
        }

        /// <summary>
        /// Returns the current number of items in the Stack
        /// </summary>
        public int Count { get { return _list.Count; } }

        /// <summary>
        /// Removes all items from the Stack
        /// </summary>
        public void Clear()
        {
            _list.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
}
