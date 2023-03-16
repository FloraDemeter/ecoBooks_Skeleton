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
            Error = aStock.Valid(tstStockName, tstDescription, tstStockQuantity, ProcessedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProcessedDateMinLessOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string ProcessedDate = DateTime.Today.AddDays(-1).ToString();
            Error = aStock.Valid(tstStockName, tstDescription, tstStockQuantity, ProcessedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProcessedDateMin()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string ProcessedDate = DateTime.Today.ToString();
            Error = aStock.Valid(tstStockName, tstDescription, tstStockQuantity, ProcessedDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProcessedDateMinAddOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string ProcessedDate = DateTime.Today.AddDays(1).ToString();
            Error = aStock.Valid(tstStockName, tstDescription, tstStockQuantity, ProcessedDate);
            Assert.AreNotEqual(Error, ""); //AreNotEqual
        }
        [TestMethod]
        public void ProcessedDateExtremeMax()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string ProcessedDate = DateTime.Today.AddYears(100).ToString();
            Error = aStock.Valid(tstStockName, tstDescription, tstStockQuantity, ProcessedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProcessedDateInvalidType()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string ProcessedDate = "not a date";
            Error = aStock.Valid(tstStockName, tstDescription, tstStockQuantity, ProcessedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProcessedDateInvalidType2()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string ProcessedDate = 13245.ToString();
            Error = aStock.Valid(tstStockName, tstDescription, tstStockQuantity, ProcessedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProcessedDateInvalidType3()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string ProcessedDate = 12321.00.ToString();
            Error = aStock.Valid(tstStockName, tstDescription, tstStockQuantity, ProcessedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMinLessOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string StockName = "";
            Error = aStock.Valid(StockName, tstDescription, tstStockQuantity, tstProcessedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockNameMin()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string StockName = "";
            Error = aStock.Valid(StockName, tstDescription, tstStockQuantity, tstProcessedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockNameMinAddOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string StockName = "01";
            Error = aStock.Valid(StockName, tstDescription, tstStockQuantity, tstProcessedDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockNameMaxLessOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string StockName = "0123456789012345678901234567890123456789012345678";
            Error = aStock.Valid(StockName, tstDescription, tstStockQuantity, tstProcessedDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockNameMax()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string StockName = "01234567890123456789012345678901234567890123456789";
            Error = aStock.Valid(StockName, tstDescription, tstStockQuantity, tstProcessedDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockNameMaxAddOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string StockName = "012345678901234567890123456789012345678901234567890";
            Error = aStock.Valid(StockName, tstDescription, tstStockQuantity, tstProcessedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockNameMid()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string StockName = "0123456789012345678901234";
            Error = aStock.Valid(StockName, tstDescription, tstStockQuantity, tstProcessedDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockNameExtremeMax()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string StockName = "012345678901234567890123456789012345678901234567890012345678901234567890123456789012345678901234567890012345678901234567890123456789012345678901234567890";
            Error = aStock.Valid(StockName, tstDescription, tstStockQuantity, tstProcessedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinLessOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string Description = "";
            Error = aStock.Valid(tstStockName, Description, tstStockQuantity, tstProcessedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMin()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string Description = "";
            Error = aStock.Valid(tstStockName, Description, tstStockQuantity, tstProcessedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMinAddOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string Description = "01";
            Error = aStock.Valid(tstStockName, Description, tstStockQuantity, tstProcessedDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string Description = "0123456789012345678901234567890123456789012345678";
            Error = aStock.Valid(tstStockName, Description, tstStockQuantity, tstProcessedDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMax()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string Description = "01234567890123456789012345678901234567890123456789";
            Error = aStock.Valid(tstStockName, Description, tstStockQuantity, tstProcessedDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionAddOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string Description = "012345678901234567890123456789012345678901234567890";
            Error = aStock.Valid(tstStockName, Description, tstStockQuantity, tstProcessedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMid()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string Description = "0123456789012345678901234";
            Error = aStock.Valid(tstStockName, Description, tstStockQuantity, tstProcessedDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionExtremeMax()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string Description = "012345678901234567890123456789012345678901234567890012345678901234567890123456789012345678901234567890012345678901234567890123456789012345678901234567890";
            Error = aStock.Valid(tstStockName, Description, tstStockQuantity, tstProcessedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityExtremeMin()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string StockQuantity = "-1000";
            Error = aStock.Valid(tstStockName, tstDescription, StockQuantity, tstProcessedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockQuantityMinLessOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string StockQuantity = "0";
            Error = aStock.Valid(tstStockName, tstDescription, StockQuantity, tstProcessedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockQuantityMin()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string StockQuantity = "1";
            Error = aStock.Valid(tstStockName, tstDescription, StockQuantity, tstProcessedDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockQuantityMinAddOne()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string StockQuantity = "2";
            Error = aStock.Valid(tstStockName, tstDescription, StockQuantity, tstProcessedDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockQuantityInvalidType()
        {
            clsStock aStock = new clsStock();
            String Error = "";
            string StockQuantity = "this is not integer";
            Error = aStock.Valid(tstStockName, tstDescription, StockQuantity, tstProcessedDate);
            Assert.AreNotEqual(Error, "");
        }



    }
        }

