using System;
using System.Collections.Generic;
using System.Text;

namespace IC.Tests.LinkedLists
{
    public class LinkedListNode
    {
        public int Value { get; set; }

        public LinkedListNode Next { get; set; }

        public LinkedListNode(int value)
        {
            Value = value;
        }

        /// <summary>
        /// Checks if a singly-linked list contains a cycle
        /// Attempt: 1
        /// Runtime Complexity: O(n)
        /// Space Complexity: O(n)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static bool ContainsCycle(LinkedListNode head)
        {
            if (head.Next == null) { return false; }
            Dictionary<LinkedListNode, int> hashTable = new Dictionary<LinkedListNode, int>();

            while (head != null)
            {
                if (hashTable.ContainsKey(head))
                {
                    return true;
                }
                hashTable.Add(head, head.Value);
                head = head.Next;
            }
            // reached the end of the link, no cycle
            return false;
        }

        /// <summary>
        /// Checks if a singly-linked list contains a cycle
        /// Attempt: 1
        /// Runtime Complexity: O(n)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static bool ContainsCycleOptimized(LinkedListNode head)
        {
            if (head.Next == null) { return false; }

            LinkedListNode slowRunner = head;
            LinkedListNode fastRunner = head;

            while (fastRunner != null && fastRunner.Next != null)
            {
                slowRunner = slowRunner.Next;
                fastRunner = fastRunner.Next.Next;
                if (fastRunner == slowRunner)
                {
                    return true;
                }
            }
            // reached the end of the link, no cycle
            return false;
        }

        /// <summary>
        /// Reverses a singly-linked list
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static LinkedListNode ReverseLinkedList(LinkedListNode head)
        {
            LinkedListNode current = head;
            LinkedListNode previousNode = null;
            LinkedListNode nextNode = null;

            while (current != null)
            {
                // Copy pointer to the Next element BEFORE we overwrite current.Next
                nextNode = current.Next;

                current.Next = previousNode;

                previousNode = current;
                current = nextNode;
            }

            return previousNode;
        }

        /// <summary>
        /// Returns the k-th to last node from a singly linked list
        /// </summary>
        /// <param name="value"></param>
        /// <param name="head"></param>
        /// <returns></returns>
        public static LinkedListNode KthToLastNode(int value, LinkedListNode head)
        {
            int lengthOfList = 0;

            var temporaryList = head;

            while (temporaryList != null)
            {
                lengthOfList++;
                temporaryList = temporaryList.Next;
            }

            LinkedListNode kthNode = null;
            for (int index = 0; index <= (lengthOfList - value); index++)
            {
                kthNode = head;
                head = head.Next;
            }

            return kthNode;
        }
    }
}
