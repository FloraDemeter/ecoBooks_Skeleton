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
            Int32 OrderNo = 6;
            Found = anOrder.Find(OrderNo);
            if (anOrder.OrderID != 6)
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
            Int32 OrderNo = 6;
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
            Int32 OrderNo = 6;
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
            Int32 OrderNo = 6;
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
            Int32 OrderNo = 6;
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
            Int32 OrderNo = 6;
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
            Int32 OrderNo = 6;
            Found = anOrder.Find(OrderNo);
            if (anOrder.OrderConfirmed != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        string tstOrderDate = DateTime.Now.Date.ToString();
        string tstCustomerNo = "45";
        string tstCustomerName = "John Smith";
        string tstStockNo = "28";
        string tstStockPrice = "4.50";

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            Error = anOrder.Valid(tstOrderDate, tstCustomerNo, tstCustomerName, tstStockNo, tstStockPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string OrderDate = DateTime.Today.AddYears(-100).ToString();
            Error = anOrder.Valid(OrderDate, tstCustomerNo, tstCustomerName, tstStockNo, tstStockPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinLessOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string OrderDate = DateTime.Today.AddDays(-1).ToString();
            Error = anOrder.Valid(OrderDate, tstCustomerNo, tstCustomerName, tstStockNo, tstStockPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMin()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string OrderDate = DateTime.Today.ToString();
            Error = anOrder.Valid(OrderDate, tstCustomerNo, tstCustomerName, tstStockNo, tstStockPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinAddOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string OrderDate = DateTime.Today.AddDays(1).ToString();
            Error = anOrder.Valid(OrderDate, tstCustomerNo, tstCustomerName, tstStockNo, tstStockPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string OrderDate = DateTime.Today.AddYears(100).ToString();
            Error = anOrder.Valid(OrderDate, tstCustomerNo, tstCustomerName, tstStockNo, tstStockPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateInvalidType()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string OrderDate = "not a date";
            Error = anOrder.Valid(OrderDate, tstCustomerNo, tstCustomerName, tstStockNo, tstStockPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateInvalidType2()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string OrderDate = 13245.ToString();
            Error = anOrder.Valid(OrderDate, tstCustomerNo, tstCustomerName, tstStockNo, tstStockPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateInvalidType3()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string OrderDate = 12321.00.ToString();
            Error = anOrder.Valid(OrderDate, tstCustomerNo, tstCustomerName, tstStockNo, tstStockPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNoExtremeMin()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string CustomerNo = "-1000";
            Error = anOrder.Valid(tstOrderDate, CustomerNo, tstCustomerName, tstStockNo, tstStockPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNoMinLessOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string CustomerNo = "0";
            Error = anOrder.Valid(tstOrderDate, CustomerNo, tstCustomerName, tstStockNo, tstStockPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNoMin()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string CustomerNo = "1";
            Error = anOrder.Valid(tstOrderDate, CustomerNo, tstCustomerName, tstStockNo, tstStockPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNoMinAddOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string CustomerNo = "2";
            Error = anOrder.Valid(tstOrderDate, CustomerNo, tstCustomerName, tstStockNo, tstStockPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNoInvalidType()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string CustomerNo = "this is not integer";
            Error = anOrder.Valid(tstOrderDate, CustomerNo, tstCustomerName, tstStockNo, tstStockPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string CustomerName = "";
            Error = anOrder.Valid(tstOrderDate, tstCustomerNo, CustomerName, tstStockNo, tstStockPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMin()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string CustomerName = "0";
            Error = anOrder.Valid(tstOrderDate, tstCustomerNo, CustomerName, tstStockNo, tstStockPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinAddOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string CustomerName = "01";
            Error = anOrder.Valid(tstOrderDate, tstCustomerNo, CustomerName, tstStockNo, tstStockPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string CustomerName = "0123456789012345678901234567890123456789012345678";
            Error = anOrder.Valid(tstOrderDate, tstCustomerNo, CustomerName, tstStockNo, tstStockPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMax()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string CustomerName = "01234567890123456789012345678901234567890123456789";
            Error = anOrder.Valid(tstOrderDate, tstCustomerNo, CustomerName, tstStockNo, tstStockPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxAddOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string CustomerName = "012345678901234567890123456789012345678901234567890";
            Error = anOrder.Valid(tstOrderDate, tstCustomerNo, CustomerName, tstStockNo, tstStockPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMid()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string CustomerName = "0123456789012345678901234";
            Error = anOrder.Valid(tstOrderDate, tstCustomerNo, CustomerName, tstStockNo, tstStockPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string CustomerName = "012345678901234567890123456789012345678901234567890012345678901234567890123456789012345678901234567890012345678901234567890123456789012345678901234567890";
            Error = anOrder.Valid(tstOrderDate, tstCustomerNo, CustomerName, tstStockNo, tstStockPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockNoExtremeMin()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string StockNo = "-1000";
            Error = anOrder.Valid(tstOrderDate, tstCustomerNo, tstCustomerName, StockNo, tstStockPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockNoMinLessOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string StockNo = "0";
            Error = anOrder.Valid(tstOrderDate, tstCustomerNo, tstCustomerName, StockNo, tstStockPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockNoMin()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string StockNo = "1";
            Error = anOrder.Valid(tstOrderDate, tstCustomerNo, tstCustomerName, StockNo, tstStockPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockNoMinAddOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string StockNo = "2";
            Error = anOrder.Valid(tstOrderDate, tstCustomerNo, tstCustomerName, StockNo, tstStockPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockNoInvalidType()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string StockNo = "this is not integer";
            Error = anOrder.Valid(tstOrderDate, tstCustomerNo, tstCustomerName, StockNo, tstStockPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockPriceExtremeMin()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string StockPrice = (-1000.00).ToString();
            Error = anOrder.Valid(tstOrderDate, tstCustomerNo, tstCustomerName, tstStockNo, StockPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockPriceMinLessOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string StockPrice = "-0.01";
            Error = anOrder.Valid(tstOrderDate, tstCustomerNo, tstCustomerName, tstStockNo, StockPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockPriceMin()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string StockPrice = "0.00";
            Error = anOrder.Valid(tstOrderDate, tstCustomerNo, tstCustomerName, tstStockNo, StockPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockPriceMinAddOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string StockPrice = "0.01";
            Error = anOrder.Valid(tstOrderDate, tstCustomerNo, tstCustomerName, tstStockNo, StockPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockPriceInvalidType()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string StockPrice = "this is not double";
            Error = anOrder.Valid(tstOrderDate, tstCustomerNo, tstCustomerName, tstStockNo, StockPrice);
            Assert.AreNotEqual(Error, "");
        }
    }
}
