using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrders> TestList = new List<clsOrders>();
            clsOrders TestItem = new clsOrders();
            TestItem.OrderID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.CustomerNo = 1;
            TestItem.CustomerName = "John Smith";
            TestItem.StockNo = 2;
            TestItem.StockPrice = 5.99;
            TestItem.OrderConfirmed = true;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrders TestItem = new clsOrders();
            TestItem.OrderID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.CustomerNo = 1;
            TestItem.CustomerName = "John Smith";
            TestItem.StockNo = 2;
            TestItem.StockPrice = 5.99;
            TestItem.OrderConfirmed = true;
            AllOrders.ThisOrder = TestItem;
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrders> TestList = new List<clsOrders>();
            clsOrders TestItem = new clsOrders();
            TestItem.OrderID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.CustomerNo = 1;
            TestItem.CustomerName = "John Smith";
            TestItem.StockNo = 2;
            TestItem.StockPrice = 5.99;
            TestItem.OrderConfirmed = true;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrders TestItem = new clsOrders();
            Int32 PrimaryKey = 0;
            TestItem.OrderID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.CustomerNo = 1;
            TestItem.CustomerName = "John Smith";
            TestItem.StockNo = 2;
            TestItem.StockPrice = 5.99;
            TestItem.OrderConfirmed = true;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrders TestItem = new clsOrders();
            Int32 PrimaryKey = 0;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.CustomerNo = 1;
            TestItem.CustomerName = "John Smith";
            TestItem.StockNo = 2;
            TestItem.StockPrice = 5.99;
            TestItem.OrderConfirmed = true;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.CustomerNo = 1234;
            TestItem.CustomerName = "AnotherJohn Smith";
            TestItem.StockNo = 23;
            TestItem.StockPrice = 15.99;
            TestItem.OrderConfirmed = false;
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrders TestItem = new clsOrders();
            Int32 PrimaryKey = 0;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.CustomerNo = 1;
            TestItem.CustomerName = "John Smith";
            TestItem.StockNo = 2;
            TestItem.StockPrice = 5.99;
            TestItem.OrderConfirmed = true;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByCustomerNoMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //FilteredOrders.ReportByCustomerNo("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByCustomerNoNoneFound()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByCustomerNo(0);
            Assert.AreEqual(0, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByCustomerNoFound()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrders.ReportByCustomerNo(97);
            if (FilteredOrders.Count == 1)
            {
                if (FilteredOrders.OrderList[0].OrderID != 6)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ReportByOrderIDMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //FilteredOrders.ReportByOrderID("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByOrderIDNoneFound()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByOrderID(0);
            Assert.AreEqual(0, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByOrderIDFound()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrders.ReportByOrderID(3);
            if (FilteredOrders.Count == 1)
            {
                if (FilteredOrders.OrderList[0].OrderID != 3)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
