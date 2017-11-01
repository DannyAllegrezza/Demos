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

        /// <summary>
        /// Given a singly linked list of integers, determine whether or not it's a palindrome.
        /// </summary>
        /// <param name="list"></param>
        /// <returns>True if the list is a palindrome, false otherwise.</returns>
        public static bool IsListPalindrome(ListNode<int> list)
        {
            Stack<int> myStack = new Stack<int>();
            var tmp = list;

            // Push all values onto the stack so we can compare
            while (tmp != null)
            {
                myStack.Push(tmp.Value);
                tmp = tmp.Next;
            }

            // Check from the tail to the head to see if the values are the same
            while (list != null)
            {
                if (list.Value != myStack.Pop())
                {
                    return false;
                }
                list = list.Next;
            }

            return true;
        }
    }

    public class ListNode<T>
    {
        public T Value { get; set; }
        public ListNode<T> Next { get; set; }
    }
}
