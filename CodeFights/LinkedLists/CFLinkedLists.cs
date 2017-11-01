using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFights.LinkedLists
{
    public class CFLinkedLists
    {
        public static ListNode<int> RemoveKFromList(ListNode<int> l, int k)
        {
            var current = l;

            if (current == null)
            {
                return null;
            }

            // we've got some nodes to step through
            while (current.Next != null)
            {
                if (current.Next.Value == k)
                {
                    current.Next = current.Next.Next;
                }
                else
                {
                    current = current.Next;
                }
            }

            // handle cases where the first value is k
            if (l.Value == k)
            {
                return l.Next;
            }
            else
            {
                return l;
            }
        }
    }

    public class ListNode<T>
    {
        public T Value { get; set; }
        public ListNode<T> Next { get; set; }
    }
}
