using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsCustomers anCustomer = new clsCustomers();
            Assert.IsNotNull(anCustomer);
        }
        [TestMethod]
        public void OrderIDPropertyOk()
        {
            clsCustomers anCustomer = new clsCustomers();
            Int32 TestData = 1;
            anCustomer.CustomerID = TestData;
            Assert.AreEqual(anCustomer.CustomerID, TestData);
        }
        [TestMethod]
        public void CustomerNameOk()
        {
            clsCustomers aCustomer = new clsCustomers();
            string TestData = "Some Name";
            aCustomer.CustomerName = TestData;
            Assert.AreEqual(aCustomer.CustomerName, TestData);
        }
        [TestMethod]
        public void CustomerDateOfBirthPropertyOk()
        {
            clsCustomers anCustomer = new clsCustomers();
            DateTime TestData = DateTime.Now.Date;
            anCustomer.CustomerDateOfBirth = TestData;
            Assert.AreEqual(anCustomer.CustomerDateOfBirth, TestData);
        }
        [TestMethod]
        public void OrderConfirmedPropertyOk()
        {
            clsOrders anOrder = new clsOrders();
            Boolean TestData = true;
            anOrder.OrderConfirmed = TestData;
            Assert.AreEqual(anOrder.OrderConfirmed, TestData);
        }
    }
}
