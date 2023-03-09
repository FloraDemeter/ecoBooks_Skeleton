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
        [TestMethod]
        public void FindMethodOk()
        {
            clsOrders anOrder = new clsOrders();
            Boolean Found = false;
            Int32 OrderNo = 1;
            Found = anOrder.Find(OrderNo);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderNoFound()
        {
            clsOrders anOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 21;
            Found = anOrder.Find(OrderNo);
            if (anOrder.OrderID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            clsOrders anOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 21;
            Found = anOrder.Find(OrderNo);
            if (anOrder.OrderDate != Convert.ToDateTime("16/01/2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerNoFound()
        {
            clsOrders anOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 21;
            Found = anOrder.Find(OrderNo);
            if (anOrder.CustomerNo != 97)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerNameFound()
        {
            clsOrders anOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 21;
            Found = anOrder.Find(OrderNo);
            if (anOrder.CustomerName != "John Smith")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockNoFound()
        {
            clsOrders anOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 21;
            Found = anOrder.Find(OrderNo);
            if (anOrder.StockNo != 45)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockPriceFound()
        {
            clsOrders anOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 21;
            Found = anOrder.Find(OrderNo);
            if (anOrder.StockPrice != 5.99)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderConfirmedFound()
        {
            clsOrders anOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 21;
            Found = anOrder.Find(OrderNo);
            if (anOrder.OrderConfirmed != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
