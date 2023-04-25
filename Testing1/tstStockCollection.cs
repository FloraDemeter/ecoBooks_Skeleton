using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Testing1
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            Assert.IsNotNull(AllStocks);
        }
        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.StockNo = 3;
            TestItem.StockName = "Stock3";
            TestItem.Description = "Book3";
            TestItem.StockQuantity = 6;
            TestItem.ProcessedDate = DateTime.Now.Date;
            TestItem.Available = true;
            TestList.Add(TestItem);
            AllStocks.StockList = TestList;
            Assert.AreEqual(AllStocks.StockList, TestList);
        }

        public void CountPropertyOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            Int32 SomeCount = 2;
            AllStocks.Count = SomeCount;
            Assert.AreEqual(AllStocks.Count, SomeCount);

        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestStock = new clsStock();
            TestStock.StockNo = 3;
            TestStock.StockName = "Stock3";
            TestStock.Description = "Book3";
            TestStock.StockQuantity = 6;
            TestStock.ProcessedDate = DateTime.Now.Date;
            TestStock.Available = true;
            AllStocks.ThisStock = TestStock;
            Assert.AreEqual(AllStocks.ThisStock, TestStock);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.StockNo = 3;
            TestItem.StockName = "Stock3";
            TestItem.Description = "Book3";
            TestItem.StockQuantity = 6;
            TestItem.ProcessedDate = DateTime.Now.Date;
            TestItem.Available = true;
            TestList.Add(TestItem);
            AllStocks.StockList = TestList;
            Assert.AreEqual(AllStocks.Count, TestList.Count);
        }

        

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 3;
            TestItem.StockName = "Stock3";
            TestItem.Description = "Book3";
            TestItem.StockQuantity = 6;
            TestItem.ProcessedDate = DateTime.Now.Date;
            TestItem.Available = true;
            AllStocks.ThisStock = TestItem;
            PrimaryKey = AllStocks.Add();
            TestItem.StockNo = PrimaryKey;
            AllStocks.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.StockName = "Stock3";
            TestItem.Description = "Book3";
            TestItem.StockQuantity = 6;
            TestItem.ProcessedDate = DateTime.Now.Date;
            TestItem.Available = true;
            AllStocks.ThisStock = TestItem;
            PrimaryKey = AllStocks.Add();
            TestItem.StockNo = PrimaryKey;
            TestItem.StockName = "Stock2";
            TestItem.Description = "Book2";
            TestItem.StockQuantity = 6;
            TestItem.ProcessedDate = DateTime.Now.Date;
            TestItem.Available = false;
            AllStocks.ThisStock = TestItem;
            AllStocks.Update();
            AllStocks.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStocks.ThisStock, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.StockNo = 3;
            TestItem.StockName = "Stock3";
            TestItem.Description = "Book3";
            TestItem.StockQuantity = 6;
            TestItem.ProcessedDate = DateTime.Now.Date;
            TestItem.Available = true;
            AllStocks.ThisStock = TestItem;
            PrimaryKey = AllStocks.Add();
            TestItem.StockNo = PrimaryKey;
            AllStocks.ThisStock.Find(PrimaryKey);
            AllStocks.Delete();
            Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByStockNameMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStockCollection FilteredStocks = new clsStockCollection();
            FilteredStocks.ReportByStockName("");
            Assert.AreEqual(AllStocks.Count, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByStockNameNoneFound()
        {
            clsStockCollection FilteredStocks = new clsStockCollection();
            FilteredStocks.ReportByStockName("xxxxxxxxxx");
            Assert.AreEqual(0, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByStockNameTestDataFound()
        {
            clsStockCollection FilteredStocks = new clsStockCollection();
            Boolean OK = true;
            FilteredStocks.ReportByStockName("Stock1");
            if (FilteredStocks.Count == 1)
            {
                if (FilteredStocks.StockList[0].StockNo != 1)
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
