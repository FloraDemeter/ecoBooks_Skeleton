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
            AnSupplier.SupplierContactNO = TestData;
            Assert.AreEqual(AnSupplier.SupplierContactNO, TestData);
        }
    }
}

















