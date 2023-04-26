using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            Assert.IsNotNull(AllSupplier);
            ;
        }
        [TestMethod]
        public void SupplierListOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.UK = true;
            TestItem.SupplierNo = 3;
            TestItem.SupplierName = " CostCutter ";
            TestItem.SupplyDate = DateTime.Now.Date;
            TestItem.SupplierAddress = " Leeds  ";
            TestItem.SupplierContactNo = 9876674;
            TestList.Add(TestItem);
            AllSupplier.SupplierList = TestList;
            Assert.AreEqual(AllSupplier.SupplierList, TestList);

        }
        public void CountPropertyOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            Int32 SomeCount = 2;
            AllSupplier.Count = SomeCount;
            Assert.AreEqual(AllSupplier.Count, SomeCount);
        }

        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            TestSupplier.UK = true;
            TestSupplier.SupplierNo = 3;
            TestSupplier.SupplierName = " CostCutter";
            TestSupplier.SupplyDate = DateTime.Now.Date;
            TestSupplier.SupplierAddress = " Leeds ";
            TestSupplier.SupplierContactNo = 9876674;
            AllSupplier.ThisSupplier = TestSupplier;
            Assert.AreEqual(AllSupplier.ThisSupplier, TestSupplier);

        }

        [TestMethod]
        public void ListAndCountOk()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.UK = true;
            TestItem.SupplierNo = 3;
            TestItem.SupplierName = " CostCutter";
            TestItem.SupplyDate = DateTime.Now.Date;
            TestItem.SupplierAddress = " Leeds ";
            TestItem.SupplierContactNo = 9876674;
            TestList.Add(TestItem);
            AllSupplier.SupplierList = TestList;
            Assert.AreEqual(AllSupplier.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsSupplierCollection Allsupplier = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.UK = true;
            TestItem.SupplierNo = 3;
            TestItem.SupplierName = " CostCutter";
            TestItem.SupplyDate = DateTime.Now.Date;
            TestItem.SupplierAddress = " Leeds ";
            TestItem.SupplierContactNo = 9876674;
            Allsupplier.ThisSupplier = TestItem;
            PrimaryKey = Allsupplier.Add();
            TestItem.SupplierNo = PrimaryKey;
            Allsupplier.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(Allsupplier.ThisSupplier, TestItem);


        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsSupplierCollection Allsupplier = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.UK = true;
            TestItem.SupplierNo = 3;
            TestItem.SupplierName = " CostCutter";
            TestItem.SupplyDate = DateTime.Now.Date;
            TestItem.SupplierAddress = " Leeds ";
            TestItem.SupplierContactNo = 9876674;
            Allsupplier.ThisSupplier = TestItem;
            PrimaryKey = Allsupplier.Add();
            TestItem.SupplierNo = PrimaryKey;
            //------------------------------

            TestItem.UK = true;
            TestItem.SupplierNo = 2;
            TestItem.SupplierName = "Nisa";
            TestItem.SupplyDate = DateTime.Now.Date;
            TestItem.SupplierAddress = " Leicester ";
            TestItem.SupplierContactNo = 5813289;
            Allsupplier.ThisSupplier = TestItem;
            PrimaryKey = Allsupplier.Add();
            TestItem.SupplierNo = PrimaryKey;

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 Primarykey = 0;
            TestItem.SupplierNo = 3;
            TestItem.SupplierName = "CostCutter";
            TestItem.SupplyDate = DateTime.Now.Date;
            TestItem.SupplierAddress = " Leeds ";
            TestItem.SupplierContactNo = 9876674;
            TestItem.UK = true;
            Primarykey = AllSupplier.Add();
            TestItem.SupplierNo = Primarykey;
            AllSupplier.ThisSupplier.Find(Primarykey);
            AllSupplier.Delete();
            Boolean Found = AllSupplier.ThisSupplier.Find(Primarykey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportBySupplierNamemethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.ReportBySupplierName("");
            Assert.AreEqual(AllSuppliers.Count, FilteredSuppliers.Count);
        }

        [TestMethod]
        public void ReportBySupplierNameFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.ReportBySupplierName("xxxxxxxxxxxxxx");
            Assert.AreEqual(0, FilteredSuppliers.Count);
        }
        [TestMethod]
        public void ReportBySupplierNameTestDataFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            Boolean OK = true;
            FilteredSuppliers.ReportBySupplierName("CostCutter");
            if (FilteredSuppliers.Count == 1)
            {
                if (FilteredSuppliers.SupplierList[0].SupplierNo != 1)
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
