using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IC.Tests.Arrays
{
    [TestClass]
    public class TestFindUniqueInts
    {
        private int[] _deliveries;

        [TestInitialize]
        public void Setup()
        {
            _deliveries = new int[] { 10, 2, 3, 10, 4, 5, 2, 5, 4, 10 };
        }

        [TestMethod]
        public void TestFindUniqueIntAmongDuplicatesUsingLINQIsValid()
        {
            
            var expected = 3;
            var actual = FindUniqueIntAmongDupes.FindUniqueIntAmongDuplicatesWithLINQ(_deliveries);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFindUniqueDeliverIdUsingXORIsValid()
        {
            var expected = 3;
            var actual = FindUniqueIntAmongDupes.FindUniqueDeliveryId(_deliveries);

            Assert.AreEqual(expected, actual);
        }
    }

    public class FindUniqueIntAmongDupes
    {
        public static int FindUniqueIntAmongDuplicatesWithLINQ(int[] deliveries)
        {
            if (deliveries == null)
            {
                throw new ArgumentNullException("deliveries");
            }

            return deliveries.GroupBy(d => d).Where(d => d.Count() == 1).Select(d => d.Key).FirstOrDefault();
        }

        public static int FindUniqueDeliveryId(int[] deliveryIds)
        {
            int uniqueDeliveryId = 0;

            foreach (int deliveryId in deliveryIds)
            {
                uniqueDeliveryId ^= deliveryId;
            }

            return uniqueDeliveryId;
        }
    }
}
