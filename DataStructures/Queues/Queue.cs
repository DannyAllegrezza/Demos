using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queues
{
    public class Queue<T> : IEnumerable<T>, IQueue<T>
    {
        private LinkedList<T> _items = new LinkedList<T>();

        /// <summary>
        /// Adds an item to the queue
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(T value)
        {
            _items.AddLast(value);
        }

        /// <summary>
        /// Removes and returns the frontmost item from the queue
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            if (Count <= 0) throw new InvalidOperationException("No items to in the Queue to dequeue");

            T value = _items.First.Value;
            // now, remove from the queue
            _items.RemoveFirst();
            return value;
        }

        public void Clear()
        {
            _items.Clear();
        }

        public int Count { get { return _items.Count; } }

        public T Peek()
        {
            if (Count <= 0) throw new InvalidOperationException("No items to in the Queue to peek at");

            return _items.First.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}
