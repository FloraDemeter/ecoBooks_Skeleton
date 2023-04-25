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
;        }
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
            TestItem.SupplierAddress = " Stamford ";
            TestItem.SupplierContactNo = 7776674;
            TestList.Add(TestItem);
            AllSupplier.SupplierList = TestList;
            Assert.AreEqual(AllSupplier.SupplierList, TestList);

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
            TestSupplier.SupplierAddress = " Stamford";
            TestSupplier.SupplierContactNo = 7776674;
            AllSupplier.ThisSupplier = TestSupplier;
            Assert.AreEqual(AllSupplier.ThisSupplier, TestSupplier);

        }

        [TestMethod]
        public void ListAnsCountOk()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.UK = true;
            TestItem.SupplierNo = 3;
            TestItem.SupplierName = " CostCutter";
            TestItem.SupplyDate = DateTime.Now.Date;
            TestItem.SupplierAddress = " Stamford";
            TestItem.SupplierContactNo = 7776674;
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
            TestItem.SupplierAddress = " Stamford";
            TestItem.SupplierContactNo = 7776674;
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
            TestItem.SupplierAddress = " Stamford";
            TestItem.SupplierContactNo = 7776674;
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
    }
}
