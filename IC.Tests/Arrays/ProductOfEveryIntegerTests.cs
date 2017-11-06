using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IC.Tests
{
    [TestClass]
    public class ProductOfEveryIntegerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetProductsOfAllIntsExceptAtIndexHasInvalidInput()
        {
            int[] badInput = new int[0];
            var result = ProductOfEveryInteger.GetProductsOfAllIntsExceptAtIndex(badInput);
        }

        [TestMethod]
        public void TestGetProductsOfAllIntsExceptAtIndexHasValidInput()
        {
            // Arrange
            int[] validInput = new int[] { 1, 7, 3, 4 };
            int[] expected = new int[] { 84, 12, 28, 21 };

            // Act
            int[] result = ProductOfEveryInteger.GetProductsOfAllIntsExceptAtIndex(validInput);
            // Assert
            CollectionAssert.AreEqual(expected, result);
        }
    }

    public class ProductOfEveryInteger
    {
        /// <summary>
        /// 1st solution, naive approach -- use 2 loops, get the product of every number unless it's 
        /// the current index in the array..
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int[] PrintProductOfOtherNumbersON2(int[] numbers)
        {
            // naive solution
            var newArray = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                int product = 1;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] != numbers[i])
                    {
                        product *= numbers[j];
                    }
                }
                newArray[i] = product;
            }


            return newArray;
        }

        /// <summary>
        /// Better solution using a greedy-algorithm:
        /// 1. Find the product of all integers BEFORE each index, then go backwards..
        /// 2. Find the product of all integers AFTER each index. As we do this, we 
        /// multiply 
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns></returns>
        public static int[] GetProductsOfAllIntsExceptAtIndex(int[] intArray)
        {
            if (intArray.Length < 2)
            {
                throw new ArgumentException("Requires at least 2 numbers", nameof(intArray));
            }

            int[] productsOfAllIntsExceptAtIndex = new int[intArray.Length];

            // For each integer, we find the product of all the integers
            // before it, storing the total product so far each time
            int productSoFar = 1;
            for (int i = 0; i < intArray.Length; i++)
            {
                productsOfAllIntsExceptAtIndex[i] = productSoFar;
                productSoFar *= intArray[i];
            }

            // For each integer, we find the product of all the integers
            // after it. since each index in products already has the
            // product of all the integers before it, now we're storing
            // the total product of all other integers
            productSoFar = 1;
            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                productsOfAllIntsExceptAtIndex[i] *= productSoFar;
                productSoFar *= intArray[i];
            }

            return productsOfAllIntsExceptAtIndex;
        }
    }
}
