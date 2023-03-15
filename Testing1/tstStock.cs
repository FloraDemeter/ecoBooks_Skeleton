using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock aStock = new clsStock();
            Assert.IsNotNull(aStock);
        }

        [TestMethod]
        public void StockNoPropertyOk()
        {
            clsStock aStock = new clsStock();
            Int32 TestData = 1;
            aStock.StockNo = TestData;
            Assert.AreEqual(aStock.StockNo, TestData);
        }

        [TestMethod]
        public void StockNamePropertyOk()
        {
            clsStock aStock = new clsStock();
            string TestData = "Some Name";
            aStock.StockName = TestData;
            Assert.AreEqual(aStock.StockName, TestData);
        }

        [TestMethod]
        public void DescriptionPropertyOk()
        {
            clsStock aStock = new clsStock();
            string TestData = "Description";
            aStock.Description = TestData;
            Assert.AreEqual(aStock.Description, TestData);
        }

        [TestMethod]
        public void StockQuantityPropertyOk()
        {
            clsStock aStock = new clsStock();
            Int32 TestData = 1;
            aStock.StockQuantity = TestData;
            Assert.AreEqual(aStock.StockQuantity, TestData);
        }

        [TestMethod]
        public void ProcessedDatePropertyOk()
        {
            clsStock aStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            aStock.ProcessedDate = TestData;
            Assert.AreEqual(aStock.ProcessedDate, TestData);
        }

        [TestMethod]
        public void AvailablePropertyOk()
        {
            clsStock aStock = new clsStock();
            Boolean TestData = true;
            aStock.Available = TestData;
            Assert.AreEqual(aStock.Available, TestData);
        }
        [TestMethod]
        public void FindMethodOk()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Int32 StockNo = 3;
            Found = aStock.Find(StockNo);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStockNoFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockNo = 3;
            Found = aStock.Find(StockNo);
            if (aStock.StockNo != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockNameFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockNo = 3;
            Found = aStock.Find(StockNo);
            if (aStock.StockName != "Stock3")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDescriptionFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockNo = 3;
            Found = aStock.Find(StockNo);
            if (aStock.Description != "Book3")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockQuantityFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockNo = 3;
            Found = aStock.Find(StockNo);
            if (aStock.StockQuantity != 6)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProcessedDateFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockNo = 3;
            Found = aStock.Find(StockNo);
            if (aStock.ProcessedDate != Convert.ToDateTime("01/01/2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAvailableFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockNo = 3;
            Found = aStock.Find(StockNo);
            if (aStock.Available != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        string tstStockName = "Stock3";
        string tstDescription = "Book3";
        string tstStockQuantity = "6";
        string tstProcessedDate = DateTime.Now.Date.ToString();
        
        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            Error = aStock.Valid(tstStockName, tstDescription, tstStockQuantity, tstProcessedDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProcessedDateExtremeMin()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string ProcessedDate = DateTime.Today.AddYears(-100).ToString();
            Error = aStock.Valid(tstStockName, tstDescription, tstStockQuantity, tstProcessedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProcessedDateMinLessOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string ProcessedDate = DateTime.Today.AddDays(-1).ToString();
            Error = aStock.Valid(tstStockName, tstDescription, tstStockQuantity, tstProcessedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProcessedDateMin()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string ProcessedDate = DateTime.Today.ToString();
            Error = aStock.Valid(tstStockName, tstDescription, tstStockQuantity, tstProcessedDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProcessedDateMinAddOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string ProcessedDate = DateTime.Today.AddDays(1).ToString();
            Error = aStock.Valid(tstStockName, tstDescription, tstStockQuantity, tstProcessedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProcessedDateExtremeMax()
        {
            clsOrders aStock = new clsOrders();
            String Error = "";
            string ProcessedDate = DateTime.Today.AddYears(100).ToString();
            Error = aStock.Valid(tstStockName, tstDescription, tstStockQuantity, tstProcessedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProcessedDateInvalidType()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string ProcessedDate = "not a date";
            Error = aStock.Valid(tstStockName, tstDescription, tstStockQuantity, tstProcessedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProcessedDateInvalidType2()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string ProcessedDate = 13245.ToString();
            Error = aStock.Valid(tstStockName, tstDescription, tstStockQuantity, tstProcessedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProcessedDateInvalidType3()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string ProcessedDate = 12321.00.ToString();
            Error = aStock.Valid(tstStockName, tstDescription, tstStockQuantity, tstProcessedDate);
            Assert.AreNotEqual(Error, "");
        }
        


    }
        }
    }

