using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerIDPropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            Int32 TestData = 1;
            ACustomer.CustomerID = TestData;
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void CustomerFullNamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Some Name";
            ACustomer.CustomerFullName = TestData;
            Assert.AreEqual(ACustomer.CustomerFullName, TestData);
        }

        [TestMethod]
        public void CustomerDateOfBirthPropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.CustomerDateOfBirth = TestData;
            Assert.AreEqual(ACustomer.CustomerDateOfBirth, TestData);
        }

        [TestMethod]
        public void CustomerGenderPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Male";
            ACustomer.CustomerGender = TestData;
            Assert.AreEqual(ACustomer.CustomerGender, TestData);
        }
        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "1 Dobson Close, Wigson, LE18 3UQ, Leicester, UK";
            ACustomer.CustomerAddress = TestData;
            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }

        [TestMethod]
        public void CustomerEmailAddressPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "shadwman.kareem@gmil.com";
            ACustomer.CustomerEmailAddress = TestData;
            Assert.AreEqual(ACustomer.CustomerEmailAddress, TestData);
        }

        [TestMethod]
        public void CustomerLoyaltyNumberPropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            Double TestData = 4554455445;
            ACustomer.CustomerLoyaltyNumber = TestData;
            Assert.AreEqual(ACustomer.CustomerLoyaltyNumber, TestData);
        }
    }
}
