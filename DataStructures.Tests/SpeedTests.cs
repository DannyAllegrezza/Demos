using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace DataStructures.Tests
{
    /// <summary>
    /// A demo class to showcase shifting the 1st element of an array to the "left", thus putting it at the end of the data structure, shifting every value to the left. 
    /// Demos pros and cons of a few data types:
    /// * LinkedList
    /// * Queue
    /// * Array (using for-loop and Array.Copy)
    /// </summary>
    [TestClass]
    public class SpeedTests
    {
        Queue<int> _testQueue = new Queue<int>();
        LinkedList<int> _testLinkedList = new LinkedList<int>();
        int[] _testArray = new int[5000000];

        [TestInitialize]
        public void Initialize()
        {
            PopulateArray();
            PopulateQueue();
            PopulateList();
        }

        [TestMethod]
        public void TestShiftArray()
        {
            var shiftedArray = Shift(_testArray);
        }

        [TestMethod]
        public void TestShiftArrayUsingArrayCopy()
        {
            var copy = ShiftCopy(_testArray);
        }

        [TestMethod]
        public void TestShiftQueue()
        {
            int v = _testQueue.Dequeue();
            _testQueue.Enqueue(v);
        }

        [TestMethod]
        public void TestShiftLinkedList()
        {
            int v = _testLinkedList.First.Value;
            _testLinkedList.RemoveFirst();
            _testLinkedList.AddLast(v);
        }

        #region Methods

        public void PopulateArray()
        {
            System.Random r = new System.Random();
            for (int i = 0; i < _testArray.Length; i++)
            {
                _testArray[i] = r.Next(0, 100);
            }
        }

        public void PopulateQueue()
        {
            System.Random r = new System.Random();
            for (int i = 0; i < 5000000; i++)
                _testQueue.Enqueue(r.Next(0, 100));
        }

        public void PopulateList()
        {
            System.Random r = new System.Random();
            for (int i = 0; i < 5000000; i++)
                _testLinkedList.AddLast(r.Next(0, 100));
        }

        public int[] Shift(int[] array)
        {
            int[] tempArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                    tempArray[i] = array[i + 1];
                else
                    tempArray[i] = array[0];
            }
            return tempArray;
        }

        public int[] ShiftCopy(int[] array)
        {
            int[] tempArray = new int[array.Length];
            int v = array[0];
            Array.Copy(array, 1, tempArray, 0, array.Length - 1);
            tempArray[tempArray.Length - 1] = v;
            return tempArray;
        }

        #endregion Methods
    }
}
