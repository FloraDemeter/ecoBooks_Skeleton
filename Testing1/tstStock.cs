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
        
            }
        }
    }

