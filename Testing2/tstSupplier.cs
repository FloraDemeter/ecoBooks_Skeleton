using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Assert.IsNotNull(AnSupplier);
        }

        [TestMethod]
        public void SupplierNoPropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Int32 TestData = 1;
            AnSupplier.SupplierNo = TestData;
            Assert.AreEqual(AnSupplier.SupplierNo, TestData);
        }

        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string TestData = "Some Name";
            AnSupplier.SupplierName = TestData;
            Assert.AreEqual(AnSupplier.SupplierName, TestData);
        }
        [TestMethod]
        public void SupplyDatePropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            AnSupplier.SupplyDate = TestData;
            Assert.AreEqual(AnSupplier.SupplyDate, TestData);
        }
        [TestMethod]
        public void UKPropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean TestData = true;
            AnSupplier.UK = TestData;
            Assert.AreEqual(AnSupplier.SupplyDate, TestData);
        }
        [TestMethod]
        public void SupplierAddressOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string TestData = "Address";
            AnSupplier.SupplierAddress = TestData;
            Assert.AreEqual(AnSupplier.SupplierAddress, TestData);
        }
        [TestMethod]
        public void SupplierContactNOPropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Int32 TestData = 1;
            AnSupplier.SupplierContactNo = TestData;
            Assert.AreEqual(AnSupplier.SupplierContactNo, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Int32 SupplierNo = 3;
            Found = AnSupplier.Find(SupplierNo);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestSupplierNoFound()
        {


            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierNo = 3;
            Found = AnSupplier.Find(SupplierNo);
            if (AnSupplier.SupplierNo != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierNameFound()
        {
            clsSupplier AnSupplier = new clsSupplier() ;
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierNo = 3;
            Found = AnSupplier.Find(SupplierNo);
            if (AnSupplier.SupplierName != "Costcutter") 
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplyDateFound()
        {
            clsSupplier Ansupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierNo = 3;
            Found = Ansupplier.Find(SupplierNo);
            if (Ansupplier.SupplyDate != Convert.ToDateTime("14/02/2023")) 
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestUKFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierNo = 3;
            Found = AnSupplier.Find(SupplierNo);
            if (AnSupplier.UK != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        string tstSupplierName = "CostCutter";
        string tstSupplierNo = "3";
        string tstSupplyDate = DateTime.Now.Date.ToString();
        
        [TestMethod]
        public void TestSupplierAddressFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierNo = 3;
            Found = AnSupplier.Find(SupplierNo);
            if (AnSupplier.SupplierAddress != "Leeds")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierContactNoFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierNo = 3;
            Found = AnSupplier.Find(SupplierNo);
            if (AnSupplier.SupplierContactNo != 9876674)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
       




        

    }
}

















