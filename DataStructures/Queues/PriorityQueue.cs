using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Queues
{
    public class PriorityQueue<T> : IQueue<T>, IEnumerable<T> where T : IComparable<T>
    {
        public int Count => _items.Count;
        private LinkedList<T> _items = new LinkedList<T>();

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public T Dequeue()
        {
            if (Count <= 0) throw new InvalidOperationException("No items to in the Queue to dequeue");

            T value = _items.First.Value;
            // now, remove from the queue
            _items.RemoveFirst();
            return value;
        }

        public void Enqueue(T item)
        {
            if (_items.Count == 0)
            {
                _items.AddLast(item);
            }
            else
            {
                // find the proper insertion point...
                var current = _items.First;

                // keep iterating through if the item being inserted has a lower value/priority 
                while (current != null && current.Value.CompareTo(item) > 0)
                {
                    current = current.Next;
                }

                if (current == null)
                {
                    // hit end of list, just add to the back
                    _items.AddLast(item);
                }
                else
                {
                    // the current item in the queue is <= the item being added, so add the item in front of it
                    _items.AddBefore(current, item);
                }
            }
        }

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
