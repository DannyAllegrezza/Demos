using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.Tests.Polymorphism
{
    [TestClass]
    public class AggregatesTests
    {
        [TestMethod]
        public void Test()
        {

        }
    }

    public class PurchaseOrder
    {
        /// <summary>
        /// Entities are defined by the fact that they indeed have a unique ID
        /// </summary>
        public int Id { get; set; }

        private List<LineItem> _items = new List<LineItem>();
        public List<LineItem> Items
        {
            get { return _items; }

            // Same thing as 
            // public List<LineItem> Items => _items;
        }

        public decimal SpendLimit { get; set; }

        public bool CheckLimit(LineItem item, decimal newValue)
        {
            var currentSum = Items.Sum(i => i.Cost);
            decimal difference = newValue - item.Cost;

            return currentSum + difference <= SpendLimit;
        }


        public bool CheckLimit(LineItem newItem)
        {
            return Items.Sum(i => i.Cost) + newItem.Cost <= SpendLimit;
        }

        public bool TryAddItem(LineItem item)
        {
            if (CheckLimit(item))
            {
                _items.Add(item);
                return true;
            }

            return false;
        }

    }

    public class LineItem
    {
        public int Id { get; set; }
        /// <summary>
        /// Can be used to get an instance of a Purcahse Order from a repo
        /// </summary>
        public int PurchaseOrderId { get; set; }
        public decimal Cost { get; private set; }

        public LineItem(decimal cost)
        {
            Cost = cost;
        }

        public bool TryUpdateCost(decimal cost, PurchaseOrder parent)
        {
            if (parent.Id != PurchaseOrderId) throw new Exception("Incorrent parent PO");

            // check if new cost would exceed PO
            if (parent.CheckLimit(this, cost))
            {
                Cost = cost;
                return true;
            }
            return false;
        }

        // alternate implementation
        public bool TryUpdateCost(decimal cost, IPurchaseOrderRepository purchaseOrderRepository)
        {
            var parent = purchaseOrderRepository.GetById(PurchaseOrderId);
            // check if new cost would exceed PO
            if (parent.CheckLimit(this, cost))
            {
                Cost = cost;
                return true;
            }
            return false;
        }
    }

    public interface IPurchaseOrderRepository
    {
        PurchaseOrder GetById(int id);
    }

    public class InMemoryPurchaseOrderRepository : IPurchaseOrderRepository
    {
        private Dictionary<int, PurchaseOrder> _collection = new Dictionary<int, PurchaseOrder>();

        public void Add(PurchaseOrder purchaseOrder)
        {
            if (!_collection.ContainsKey(purchaseOrder.Id))
            {
                _collection.Add(purchaseOrder.Id, purchaseOrder);
            }
        }

        public PurchaseOrder GetById(int id)
        {
            if (!_collection.ContainsKey(id))
            {
                return null;
            }

            return _collection[id];
        }
    }

    [TestClass]
    public class AggregateTest
    {
        [TestMethod]
        public void AddItemAboveLimit_ReturnsFalse()
        {

            var po = new PurchaseOrder()
            {
                SpendLimit = 100
            };

            // Works because we are under the limit
            Assert.IsTrue(po.TryAddItem(new LineItem(50)));

            // Now, we are going to try and add an invalid line item..
            var item = new LineItem(51);
            Assert.IsFalse(po.TryAddItem(item));
        }

        [TestMethod]
        public void UpdateItemAboveLimit_ReturnsFalse_WithRespository()
        {
            var inMemoryRepo = new InMemoryPurchaseOrderRepository();

            var purchaseOrder = new PurchaseOrder()
            {
                SpendLimit = 100
            };

            inMemoryRepo.Add(purchaseOrder);

            // Act
            Assert.IsTrue(purchaseOrder.TryAddItem(new LineItem(50)));
            var item = new LineItem(25);
            Assert.IsTrue(purchaseOrder.TryAddItem(item));

            // Assert
            Assert.IsFalse(item.TryUpdateCost(51, inMemoryRepo));
            // using the in memory repo validates we couldn't use the wrong PO ever

        }
    }
}
