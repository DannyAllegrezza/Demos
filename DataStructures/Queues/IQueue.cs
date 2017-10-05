using System.Collections.Generic;

namespace DataStructures.Queues
{
    public interface IQueue<T>
    {
        int Count { get; }

        void Clear();
        T Dequeue();
        void Enqueue(T value);
        IEnumerator<T> GetEnumerator();
        T Peek();
    }
}