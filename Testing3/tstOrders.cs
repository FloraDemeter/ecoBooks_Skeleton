using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrders anOrder = new clsOrders();
            Assert.IsNotNull(anOrder);
        }

        [TestMethod]
        public void OrderIDPropertyOk()
        {
            clsOrders anOrder = new clsOrders();
            Int32 TestData = 1;
            anOrder.OrderID = TestData;
            Assert.AreEqual(anOrder.OrderID, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOk()
        {
            clsOrders anOrder = new clsOrders();
            DateTime TestData = DateTime.Now.Date;
            anOrder.OrderDate = TestData;
            Assert.AreEqual(anOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void CustomerNoPropertyOk()
        {
            clsOrders anOrder = new clsOrders();
            Int32 TestData = 1;
            anOrder.CustomerNo = TestData;
            Assert.AreEqual(anOrder.CustomerNo, TestData);
        }

        [TestMethod]
        public void CustomerNamePropertyOk()
        {
            clsOrders anOrder = new clsOrders();
            string TestData = "Some Name";
            anOrder.CustomerName = TestData;
            Assert.AreEqual(anOrder.CustomerName, TestData);
        }

        [TestMethod]
        public void StockNoPropertyOk()
        {
            clsOrders anOrder = new clsOrders();
            Int32 TestData = 1;
            anOrder.StockNo = TestData;
            Assert.AreEqual(anOrder.StockNo, TestData);
        }

        [TestMethod]
        public void StockPricePropertyOk()
        {
            clsOrders anOrder = new clsOrders();
            Double TestData = 1.99;
            anOrder.StockPrice = TestData;
            Assert.AreEqual(anOrder.StockPrice, TestData);
        }

        [TestMethod]
        public void OrderConfirmedPropertyOk()
        {
            clsOrders anOrder = new clsOrders();
            Boolean TestData = true;
            anOrder.OrderConfirmed = TestData;
            Assert.AreEqual(anOrder.OrderConfirmed, TestData);
        }

    }
}
