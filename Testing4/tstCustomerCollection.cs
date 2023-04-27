using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection allcustomers = new clsCustomerCollection();
            Assert.IsNotNull(allcustomers);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection CustomerDetails = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.CustomerID = 1;
            TestItem.CustomerFullName = "Shad";
            TestItem.CustomerAddress = "33 Wigston";
            TestItem.CustomerEmailAddress = "Ahmet.45@gmail.com";
            TestItem.CustomerDateOfBirth = DateTime.Now.Date;
            TestItem.CustomerLoyalty = true;
            TestList.Add(TestItem);
            CustomerDetails.customerlist = TestList;
            Assert.AreEqual(CustomerDetails.customerlist, TestList);
        }


        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection allcustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerFullName = "Shad";
            TestCustomer.CustomerAddress = "33 Wigston";
            TestCustomer.CustomerEmailAddress = "Ahmet.45@gmail.com";
            TestCustomer.CustomerDateOfBirth = DateTime.Now.Date;
            TestCustomer.CustomerLoyalty = true;
            allcustomers.thiscustomer = TestCustomer;
            Assert.AreEqual(allcustomers.thiscustomer, TestCustomer);
        }


        [TestMethod]
        public void ListAndCount()
        {
            clsCustomerCollection Allcustomer = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of the test date
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.CustomerFullName = "Shad";
            TestItem.CustomerAddress = "33 Wigston";
            TestItem.CustomerEmailAddress = "Ahmet.45@gmail.com";
            TestItem.CustomerDateOfBirth = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to te property
            Allcustomer.customerlist = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Allcustomer.Count, TestList.Count);
        }
        



        //        not showing the added atributes to the list.
        //        [TestMethod]
        //        public void AddMethodOK()
        //        {
        //            create an instance of the class we want to create
        //            clsCustomerCollection allcustomers = new clsCustomerCollection();
        //        create the item of test data
        //            clsCustomer TestItem = new clsCustomer();
        //        var to store the primary key
        //            Int32 PrimaryKey = 0;
        //        set its properties
        //        TestItem.Name = "Kishan";
        //        TestItem.EmailAddress = "kishan_01@gmail.com";
        //            TestItem.PhoneNumber = 1234567;
        //            TestItem.DateofBirth = DateTime.Now.Date;
        //            TestItem.ActiveAccount = true;
        //            set thiscustomer to the test data
        //            allcustomers.thiscustomer = TestItem;
        //            ad the record
        //            PrimaryKey = allcustomers.Add();
        //        set the primary key of hte test data
        //            TestItem.CustomerID = PrimaryKey;
        //            find the recorfd
        //            allcustomers.thiscustomer.Find(PrimaryKey);
        //        test to se that the two values are the same
        //            Assert.AreEqual(allcustomers.thiscustomer, TestItem);
        //        }

        //    [TestMethod]
        //    public void UpdateMethodOK()
        //    {
        //        clsCustomerCollection allcustomers = new clsCustomerCollection();
        //        clsCustomer TestItem = new clsCustomer();
        //        Int32 PrimaryKey = 0;
        //        TestItem.Name = "Kishan";
        //        TestItem.EmailAddress = "kishan@gmail.com";
        //        TestItem.PhoneNumber = 2456;
        //        TestItem.DateofBirth = DateTime.Now.Date;
        //        TestItem.ActiveAccount = true;
        //        set thiscustomer to the test data
        //            allcustomers.thiscustomer = TestItem;
        //        add the record
        //        PrimaryKey = allcustomers.Add();
        //        set the primary key of test date
        //            TestItem.CustomerID = PrimaryKey;
        //        modify the test date
        //            TestItem.Name = "Paul";
        //        TestItem.EmailAddress = "Paul@gmail.com";
        //        TestItem.PhoneNumber = 24679898;
        //        TestItem.DateofBirth = DateTime.Now.Date;
        //        TestItem.ActiveAccount = false;
        //        set the record based on the new test data
        //            allcustomers.thiscustomer = TestItem;
        //        update the record
        //            allcustomers.Update();
        //        find the record
        //            allcustomers.thiscustomer.Find(PrimaryKey);
        //        Assert.AreEqual(allcustomers.thiscustomer, TestItem);
        //    }

        //    delete button is working
        //    [TestMethod]
        //        public void DeleteMethodOK()
        //    {
        //        create an instance of the class we want to create
        //        clsCustomerCollection allcustomers = new clsCustomerCollection();
        //    create the item of test data
        //            clsCustomer TestItem = new clsCustomer();
        //    var to store the primary key
        //            Int32 PrimaryKey = 0;
        //    set its properties
        //    TestItem.Name = "Paul";
        //    TestItem.EmailAddress = "Paul@gmail.com";
        //            TestItem.PhoneNumber = 24679898;
        //            TestItem.DateofBirth = DateTime.Now.Date;
        //            TestItem.ActiveAccount = true;
        //            set thiscustomer to the test data
        //            allcustomers.thiscustomer = TestItem;
        //            ad the record
        //            PrimaryKey = allcustomers.Add();
        //    set the primary key of hte test data
        //            TestItem.CustomerID = PrimaryKey;
        //            find the recorfd
        //            allcustomers.thiscustomer.Find(PrimaryKey);
        //    delete method
        //            allcustomers.Delete();
        //            find the record
        //            Boolean Found = allcustomers.thiscustomer.Find(PrimaryKey);
        //            test to see that the record was not found
        //            Assert.IsFalse(Found);
        //}

        //[TestMethod]
        //public void ReportbyNameMethodOK()
        //{
        //    create an instance of the class containing unfiltered results
        //            clsCustomerCollection allcustomers = new clsCustomerCollection();
        //create an instance of he filtered data
        //            clsCustomerCollection filteredname = new clsCustomerCollection();
        //apply a blank string(should return all records;
        //filteredname.ReportByName("");
        //test to see that the two values are the same
        //            Assert.AreEqual(allcustomers.Count, filteredname.Count);
        //        }

        //        [TestMethod]
        //public void ReportByNameNoneFound()
        //{
        //    clsCustomerCollection filteredname = new clsCustomerCollection();
        //    apply a post code that does not exist
        //            filteredname.ReportByName("yyy");
        //    test to see that there are no records
        //            Assert.AreEqual(0, filteredname.Count);
        //}

        //[TestMethod]
        //public void ReportByNameTestdataFound()
        //{
        //    create an instance of the filtered data
        //    clsCustomerCollection filterednames = new clsCustomerCollection();
        //    var to store outcome
        //            Boolean OK = true;
        //    apply a name that does not exist
        //            filterednames.ReportByName("Raj");
        //    check that the correct number of records are found
        //            if (filterednames.Count == 1)
        //    {
        //        check that te first record is ID
        //                if (filterednames.customerlist[0].CustomerID != 3)
        //        {
        //            OK = false;
        //        }
        //    }
        //    else
        //    {
        //        OK = false;
        //    }
        //    Assert.IsTrue(OK);

        //}

    }
}
