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
        string tstSupplierAddress = "Stamford";
        string tstSupplierContactNo = "07776674";
        private string tstSupplierAddressOK;

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
        [TestMethod]
        public void ValidMethodOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            Error = AnSupplier.Valid(tstSupplierName,tstSupplyDate, tstSupplierAddressOK, tstSupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "";
            Error = AnSupplier.Valid(SupplierName, tstSupplyDate, tstSupplierAddress, tstSupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "";
            Error = AnSupplier.Valid(SupplierName, tstSupplyDate, tstSupplierAddress, tstSupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMinAddOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "01";
            Error = AnSupplier.Valid(SupplierName, tstSupplyDate, tstSupplierAddress, tstSupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "0123456789012345678901234567890123456789";
            Error = AnSupplier.Valid(SupplierName, tstSupplyDate, tstSupplierAddress, tstSupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "01234567890123456789012345678901234567890";
            Error = AnSupplier.Valid(SupplierName, tstSupplyDate, tstSupplierAddress, tstSupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMaxAddOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "0123456789012345678901234567890123456789";
            Error = AnSupplier.Valid(SupplierName, tstSupplyDate, tstSupplierAddress, tstSupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "0123456789901234567891234567890123456789";
            Error = AnSupplier.Valid(SupplierName, tstSupplyDate, tstSupplierAddress, tstSupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "012345678901234567890123456789012345678901234567890012345678901234567890123456789012345678901234567890012345678901234567890123456789012345678901234567890";
            Error = AnSupplier.Valid(SupplierName, tstSupplyDate, tstSupplierAddress, tstSupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierAddressMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierAddress = "";
            Error = AnSupplier.Valid(tstSupplierName, tstSupplyDate, SupplierAddress, tstSupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierAddressMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierAddress = "";
            Error = AnSupplier.Valid(tstSupplierName, tstSupplyDate, SupplierAddress, tstSupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierAddressMinAddOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierAddress = "01";
            Error = AnSupplier.Valid(tstSupplierName, tstSupplyDate, SupplierAddress, tstSupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierAddressMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierAddress = "01234567890123445667890123456778901234567890123456789";
            Error = AnSupplier.Valid(tstSupplierName, tstSupplyDate, SupplierAddress, tstSupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierAddressMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierAddress = "01234567890123456789012345678901234567890123456789";
            Error = AnSupplier.Valid(tstSupplierName, tstSupplyDate, SupplierAddress, tstSupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierAddressMaxAddOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierAddress = "01234567890123456789012345678901234567890123456789";
            Error = AnSupplier.Valid(tstSupplierName, tstSupplyDate, SupplierAddress, tstSupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierAddressMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierAddress = "012345678901234567890123456789";
            Error = AnSupplier.Valid(tstSupplierName, tstSupplyDate, SupplierAddress, tstSupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierAddressExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierAddress = "012345678901234567890123456789012345678901234567890012345678901234567890123456789012345678901234567890012345678901234567890123456789012345678901234567890";
            Error = AnSupplier.Valid(tstSupplierName, tstSupplyDate, SupplierAddress, tstSupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierContactNoMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierContactNo = "";u
            Error = AnSupplier.Valid(tstSupplierName, tstSupplyDate, tstSupplierAddress, SupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierContactNoMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierContactNo = "";
            Error = AnSupplier.Valid(tstSupplierName, tstSupplyDate, tstSupplierAddress, SupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierContactNoMinAddOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierContactNo = "01";
            Error = AnSupplier.Valid(tstSupplierName, tstSupplyDate, tstSupplierAddress, SupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierContactNoMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierContactNo = "07776556638";
            Error = AnSupplier.Valid(tstSupplierName, tstSupplyDate, tsjzsnxstSupplierAddress, SupplierContactNo);
            Assert.AreEqual(Error, """);
        }
        [TestMethod]
        public void SupplierContactNoMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierContactNo = "07776556638";
            Error = AnSupplier.Valid(tstSupplierName, tstSupplyDate, tstSupplierAddress, SupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierContactNoMaxAddOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierContactNo = "07776556638";
            Error = AnSupplier.Valid(tstSupplierName, tstSupplyDate, tstSupplierAddress, SupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierContactNoMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierContactNo = "07776556638";
            Error = AnSupplier.Valid(tstSupplierName, tstSupplyDate, tstSupplierAddress, SupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierContactNoExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierContactNo = "077765566380777655663807776556638077765566380777655663807776556638077765566380777655663807776556638";
            Error = AnSupplier.Valid(tstSupplierName, tstSupplyDate, tstSupplierAddress, SupplierContactNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplyDateExtremeMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplyDate = DateTime.Today.AddYears(-100).ToString();
            Error = AnSupplier.Valid(tstSupplierName, SupplyDate, tstSupplierAddress, tstSupplierContactNo);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplyDateMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplyDate = DateTime.Today.AddDays(-1).ToString();
            Error = AnSupplier.Valid(tstSupplierName,SupplyDate, tstSupplierAddress, tstSupplierContactNo);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplyDateMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplyDate = DateTime.Today.ToString();
            Error = AnSupplier.Valid(tstSupplierName, SupplyDate, tstSupplierAddress, tstSupplierContactNo);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void SupplyDateMinAddOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplyDate = DateTime.Today.AddDays(1).ToString();
            Error = AnSupplier.Valid(tstSupplierName, SupplyDate, tstSupplierAddress, tstSupplierContactNo);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void SupplyDateExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplyDate = DateTime.Today.AddDays(1).ToString();
            Error = AnSupplier.Valid(tstSupplierName, SupplyDate, tstSupplierAddress, tstSupplierContactNo);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void SupplyDateInvalidType()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplyDate = "not a Date";
            Error = AnSupplier.Valid(tstSupplierName, SupplyDate, tstSupplierAddress, tstSupplierContactNo);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplyDateInvalidType2()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplyDate = 1234.ToString();
            Error = AnSupplier.Valid(tstSupplierName, SupplyDate, tstSupplierAddress, tstSupplierContactNo);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void SupplyDateInvalid3()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplyDate = 1234.78.ToString();
            Error = AnSupplier.Valid(tstSupplierName,SupplyDate, tstSupplierAddress, tstSupplierContactNo);
            Assert.AreNotEqual(Error, "");

        }
       
        
       





    }
}

















