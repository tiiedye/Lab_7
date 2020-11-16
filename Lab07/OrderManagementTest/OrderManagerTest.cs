using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OrderManagementTest
{
    [TestClass]
    public class OrderManagerTest
    {
        [Ignore]
        [TestMethod]
        public void CalculateShipping1()
        {
            double weight = 0.33;
            var orderMgr = new OrderManagement.OrderManager();
            var cost = orderMgr.CalculateShipping(weight);

            Assert.AreEqual(2.5, cost);
        }

        [TestMethod]
        public void CalculateShipping2()
        {
            double weight = 3.5;
            var orderMgr = new OrderManagement.OrderManager();
            var cost = orderMgr.CalculateShipping(weight);

            Assert.AreEqual(8, cost);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void CalculateShipping3()
        {
            double weight = 25;
            var orderMgr = new OrderManagement.OrderManager();
            var cost = orderMgr.CalculateShipping(weight);

            Assert.AreEqual(8, cost);
        }
    }
}
