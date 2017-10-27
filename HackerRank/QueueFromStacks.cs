using System;
using System.Collections;
using System.Collections.Generic;

namespace HackerRank.QueueFromStack
{
    /*
    https://www.hackerrank.com/challenges/ctci-queue-using-two-stacks/problem
    Create a queue that is implemented using two stacks. Must be able to:
    1. Enqueue an item
    2. Dequeue an item
    3. Peek at head of queue
     */
    public class Queue
    {
        private Stack _input = new Stack();
        private Stack _output = new Stack();
        private int size;

        public void Enqueue(int item)
        {
            _input.Push(item);
            size++;
        }

        public void Dequeue()
        {
            if (_output.IsEmpty)
            {
                while (!_input.IsEmpty)
                {
                    _output.Push(_input.Pop());
                }
            }

            if (_output.Count > 0)
            {
                _output.Pop();
                size--;
            }
        }

        // Return the item that is in the front of the Queue
        public void PeekAndPrint()
        {
            if (_output.Count == 0)
            {
                while (!_input.IsEmpty)
                {
                    _output.Push(_input.Pop());
                }
            }
            int head = _output.Peek();

            Console.WriteLine(head);
        }

        public int Count { get{return size;}}
    }

    public class Stack : IEnumerable
    {
        private LinkedList<int> _list = new LinkedList<int>();

        public int Pop()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("No items on the Stack to Pop");
            }

            int value = _list.First.Value;
            _list.RemoveFirst();

            return value;
        }

        public void Push(int item)
        {
            _list.AddFirst(item);
        }

        public int Peek()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("No items on the Stack to Pop");
            }

            return _list.First.Value;
        }

        public int Count
        {
            get { return _list.Count; }
        }

        public bool IsEmpty
        {
            get { return _list.Count == 0; }
        }

        public void Clear()
        {
            _list.Clear();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
}