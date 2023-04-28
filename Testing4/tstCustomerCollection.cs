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
            TestItem.CustomerID = 2;
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
            clsCustomerCollection Allcustomer = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.CustomerID = 2;
            TestCustomer.CustomerFullName = "Shad";
            TestCustomer.CustomerAddress = "33 Wigston";
            TestCustomer.CustomerEmailAddress = "Ahmet.45@gmail.com";
            TestCustomer.CustomerDateOfBirth = DateTime.Now.Date;
            TestCustomer.CustomerLoyalty = true;
            Allcustomer.thiscustomer = TestCustomer;
            Assert.AreEqual(Allcustomer.thiscustomer, TestCustomer);
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
            TestItem.CustomerID = 2;
            TestItem.CustomerFullName = "Shad";
            TestItem.CustomerAddress = "33 Wigston";
            TestItem.CustomerEmailAddress = "Ahmet.45@gmail.com";
            TestItem.CustomerDateOfBirth = DateTime.Now.Date;
            TestItem.CustomerLoyalty = true;

            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to te property
            Allcustomer.customerlist = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Allcustomer.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerID = 2;
            TestItem.CustomerLoyalty = true;
            TestItem.CustomerFullName = "Shad";
            TestItem.CustomerAddress = "33 Wigston";
            TestItem.CustomerEmailAddress = "Ahmet.45@gmail.com";
            TestItem.CustomerDateOfBirth = DateTime.Now.Date;
            AllCustomer.thiscustomer = TestItem;
            PrimaryKey = AllCustomer.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomer.thiscustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomer.thiscustomer, TestItem);
        }


        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerFullName = "Hana";
            TestItem.CustomerAddress = "89 Dobson Close";
            TestItem.CustomerEmailAddress = "shadwman.kareem20@gmail.com";
            TestItem.CustomerDateOfBirth = DateTime.Now.Date;
            TestItem.CustomerLoyalty = true;
            //set thiscustomer to the test data
            AllCustomer.thiscustomer = TestItem;
            PrimaryKey = AllCustomer.Add();
            //set the primary key of test date
            TestItem.CustomerID = PrimaryKey;
            //modify the test date
            TestItem.CustomerFullName = "Tony Mike";
            TestItem.CustomerAddress = "90, King Richard";
            TestItem.CustomerEmailAddress = "shakan.ahmet@gmail.com";
            TestItem.CustomerDateOfBirth = DateTime.Now.Date;
            TestItem.CustomerLoyalty = false;
            //set the record based on the new test data
            AllCustomer.thiscustomer = TestItem;
            //update the record
            AllCustomer.Update();
            //find the record
            AllCustomer.thiscustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomer.thiscustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerLoyalty = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerFullName = "Shadwman Kareem";
            TestItem.CustomerEmailAddress = "shadwman.kareem@gmail.com";
            TestItem.CustomerDateOfBirth = DateTime.Now.Date;
            TestItem.CustomerAddress = "1 Dobson Close";
            AllCustomer.thiscustomer = TestItem;
            PrimaryKey = AllCustomer.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomer.thiscustomer.Find(PrimaryKey);
            AllCustomer.Delete();
            Boolean Found = AllCustomer.thiscustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }


        //[TestMethod]
        //public void ReportByCustomerFullNameMethodOK()
        //{
        //    //create an instance of the class containing unfiltered results
        //            clsCustomerCollection Allcustomer = new clsCustomerCollection();
        ////create an instance of he filtered data
        //            clsCustomerCollection FilteredCustomerFullName = new clsCustomerCollection();
        //    //apply a blank string (should return all records;
        //    FilteredCustomerFullName.ReportByCustomerFullName("");
        //    //test to see that the two values are the same
        //    Assert.AreEqual(Allcustomer.Count, FilteredCustomerFullName.Count);
        //        }

        //[TestMethod]
        //public void ReportByCustomerFullNameNoneFound()
        //{
        //    clsCustomerCollection FilteredCustomerFullName = new clsCustomerCollection();
        //    //apply a post code that does not exist
        //    FilteredCustomerFullName.ReportByCustomerFullName("yyyy");
        //    // test to see that there are no records
        //    Assert.AreEqual(0, FilteredCustomerFullName.Count);
        //}

        //[TestMethod]
        //public void ReportByFullNameTestdataFound()
        //{
        //    //create an instance of the filtered data
        //    clsCustomerCollection FilteredCustomerFullName = new clsCustomerCollection();
        //    //var to store outcome
        //    Boolean OK = true;
        //    //// apply a name that does not exist
        //    //FilteredCustomerFullName.ReportByCustomerFullName("Kaya");
        //    // check that the correct number of records are found
        //    //if (FilteredCustomerFullName.Count == 1)
        //    //{
        //    //    // check that te first record is ID
        //    //    if (FilteredCustomerFullName.Customerlist[0].CustomerID != 3)
        //    //    {
        //    //        OK = false;
        //    //    }
            //}
            //else
            //{
            //    OK = false;
            //}
            //Assert.IsTrue(OK);

        }

    }

