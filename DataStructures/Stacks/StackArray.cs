using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Stacks
{
    /// <summary>
    /// A stack, backed by an array as opposed to a LinkedList
    /// </summary>
    public class StackArray<T> : IEnumerable<T>
    {
        T[] _items = new T[0];

        // Number of items currently in the stack
        private int _size;

        public void Push(T item)
        {
            // If necessary, grow the array
            if (_size == _items.Length)
            {
                int newLength = (_size == 0) ? 4 : _size * 2;

                // Allocate new array, copy old array and assign the new array
                T[] newArray = new T[newLength];
                _items.CopyTo(newArray, 0);
                _items = newArray;

            }
            // add the item to the stack array and increase size
            _items[_size] = item;
            _size++;
        }

        public T Pop()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("The Stack is Empty!");
            }
            // Return last item in array
            _size--;
            return _items[_size];
        }

        public T Peek()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("The Stack is Empty!");
            }
            
            return _items[_size - 1];
        }

        /// <summary>
        /// The current number of items in the Stack
        /// </summary>
        public int Count { get { return _size; } }

        /// <summary>
        /// Removes all items on the Stack by setting size to 0. Works for integers
        /// NOTE: Won't work for complex object types, they will still be in the array.
        /// </summary>
        public void Clear()
        {
            _size = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            // we're counting "backwards" from the end/head of the array to the 0th element
            for (int i = _size -1; i >= 0; i--)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
