using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {
        string CustomerFullName = "Shdwman Kareem";
        string CustomerAddress = "1,Dobson Close, Wigston, Leicester";
        String CustomerEmailAddress = "shadwman.kareem@gmail.com";
        string CustomerDateOfBirth = Convert.ToDateTime("08/01/2000").ToString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACostumer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACostumer);
        }
        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            ACustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void CustomerFullNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACostumer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "Selena Gomez";
            //assign the data to the property
            ACostumer.CustomerFullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACostumer.CustomerFullName, TestData);
        }

        [TestMethod]
        public void CustomerAddressOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACostumer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "70, Great Arler Road, Leicester";
            //assign the data to the property
            ACostumer.CustomerAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACostumer.CustomerAddress, TestData);
        }

        [TestMethod]
        public void CustomerDateOfBirthOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACostumer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACostumer.CustomerDateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACostumer.CustomerDateOfBirth, TestData);
        }

        [TestMethod]
        public void CustomerEmailAddressOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACostumer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "Shadw.karlos20@gmail.com";
            //assign the data to the property
            ACostumer.CustomerEmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACostumer.CustomerEmailAddress, TestData);
        }

        [TestMethod]
        public void CustomerLoyaltyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACostumer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACostumer.CustomerLoyalty = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACostumer.CustomerLoyalty, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer customer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 customerID = 1234;
            //invoke the method
            Found = customer.Find(customerID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void CustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean varibe to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerID = 1234;
            //invole the method
            Found = customer.Find(customerID);
            //check the customer ID
            if (customer.CustomerID != 1234)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerFullNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean varibe to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerID = 1234;
            //invole the method
            Found = customer.Find(customerID);
            //check the customer ID
            if (customer.CustomerFullName != "shadwman kareem")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerEmailAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean varibe to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerID = 1234;
            //invole the method
            Found = customer.Find(customerID);
            //check the customer ID
            if (customer.CustomerEmailAddress != "shadwman.kareem@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void CustomerDateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean varibe to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerID = 1234;
            //invole the method
            Found = customer.Find(customerID);
            //check the customer ID
            if (customer.CustomerDateOfBirth != Convert.ToDateTime("09/09/2009"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean varibe to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerID = 1234;
            //invole the method
            Found = customer.Find(customerID);
            //check the customer ID
            if (customer.CustomerAddress != "1 dobson close")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerLoyaltyFound()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean varibe to record if data is OK
            bool OK = true;
            //create some test data to use with the method
            Int32 customerID = 1234;
            //invole the method
            Found = customer.Find(customerID);
            //check the customer ID
            if (customer.CustomerLoyalty != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullNameMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            //String variable to store any message
            string Error = "";
            //create some test data to pass to the method
            string CustomerFullName = ""; //this should trigger an error
            //invoke method
            Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFullNameMin()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string CustomerFullName = "a"; //this should trigger an error
                //invoke method
                Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
        }


        [TestMethod]
        public void CustomerFullNameMinPlusOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string CustomerFullName = "aa"; //this should trigger an error
                //invoke method
                Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void CustomerFullNameNoMaxLessOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string CustomerFullName = "";
                CustomerFullName = CustomerFullName.PadRight(49, 'a');
                //invoke method
                Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
        }


        [TestMethod]
        public void CustomerFullNameMax()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string CustomerFullName = "";
                CustomerFullName = CustomerFullName.PadRight(50, 'a');
                //invoke method
                Error = customer.Valid(CustomerFullName, CustomerGender, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void CustomerFullNameMid()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string CustomerFullName = "";
                CustomerFullName = CustomerFullName.PadRight(25, 'a');
                //invoke method
                Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void CustomerFullNameMaxPlusOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string CustomerFullName = "";
                CustomerFullName = CustomerFullName.PadRight(51, 'a');
                //invoke method
                Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
        }

        [TestMethod]
        public void CustomerFullNameExtremeMax()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string CustomerFullName = "";
                CustomerFullName = CustomerFullName.PadRight(500, 'a');
                //invoke method
                Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
        }

        [TestMethod]
        public void CustomerEmailAddressMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            //String variable to store any message
            string Error = "";
            //create some test data to pass to the method
            string CustomerEmailAddress = ""; //this should trigger an error
            //invoke method
            Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailAddressMin()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string CustomerEmailAddress = "a"; //this should trigger an error
                //invoke method
                Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void CustomerEmailAddressMinPlusOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string CustomerEmailAddress = "aa"; //this should trigger an error
                //invoke method
                Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void CustomerEmailAddressNoMaxLessOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string CustomerEmailAddress = "";
                CustomerEmailAddress = CustomerEmailAddress.PadRight(49, 'a');
                //invoke method
                Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void CustomerEmailAddressMax()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string CustomerEmailAddress = "";
                CustomerEmailAddress = CustomerEmailAddress.PadRight(50, 'a');
                //invoke method
                Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void CustomerEmailAddressMid()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string CustomerEmailAddress = "";
                CustomerEmailAddress = CustomerEmailAddress.PadRight(25, 'a');
                //invoke method
                Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void CustomerEmailAddressMaxPlusOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string CustomerEmailAddress = "";
                CustomerEmailAddress = CustomerEmailAddress.PadRight(51, 'a');
                //invoke method
                Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
        }

        [TestMethod]
        public void CustomerEmailAddressExtremeMax()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string CustomerEmailAddress = "";
                CustomerEmailAddress = CustomerEmailAddress.PadRight(500, 'a');
                //invoke method
                Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
        }

        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string CustomerAddress = "";
                Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                Assert.AreNotEqual(Error, "");
            }
        }
        [TestMethod]
        public void CustomerAddressMin()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string CustomerAddress = "1";
                Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string CustomerAddress = "11";
                Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string CustomerAddress = "11111111111";
                Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                Assert.AreEqual(Error, "");
            }
        }
        [TestMethod]
        public void CustomerAddressMax()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string CustomerAddress = "";
                CustomerEmailAddress = CustomerEmailAddress.PadRight(50, '1');
                Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string CustomerAddress = "";
                CustomerEmailAddress = CustomerEmailAddress.PadRight(51, '1');
                Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                Assert.AreNotEqual(Error, "");
            }
        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string CustomerAddress = "";
                CustomerEmailAddress = CustomerEmailAddress.PadRight(25, '1');
                Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void CustomerAddressExtemeMax()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string CustomerAddress = "";
                CustomerAddress = CustomerAddress.PadRight(500, '1');
                Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
                Assert.AreNotEqual(Error, "");
            }
        }

        [TestMethod]
        public void CustomerDateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string varaible to store any error message
            String Error = "";
            //create a variabe to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 1000 years
            TestDate = TestDate.AddYears(-1000);
            //convert the date variable to a string variable
            string CustomerDateOfBirth = TestDate.ToString();
            //invoke method
            Error = customer.Valid(CustomerFullName, , CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string varaible to store any error message
            String Error = "";
            //create a variabe to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years and 1 day
            TestDate = TestDate.AddYears(-100).AddDays(-1);
            //convert the date variable to a string variable
            string CustomerDateOfBirth = TestDate.ToString();
            //invoke method
            Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string varaible to store any error message
            String Error = "";
            //create a variabe to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string CustomerDateOfBirth = TestDate.ToString();
            //invoke method
            Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string varaible to store any error message
            String Error = "";
            //create a variabe to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years plus 1 day
            TestDate = TestDate.AddYears(-100).AddDays(1);
            //convert the date variable to a string variable
            string CustomerDateOfBirth = TestDate.ToString();
            //invoke method
            Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string varaible to store any error message
            String Error = "";
            //create a variabe to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is more than 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string CustomerDateOfBirth = TestDate.ToString();
            //invoke method
            Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthMax()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string varaible to store any error message
            String Error = "";
            //create a variabe to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 18 years
            TestDate = TestDate.AddYears(-20);
            //convert the date variable to a string variable
            string CustomerDateOfBirth = TestDate.ToString();
            //invoke method
            Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string varaible to store any error message
            String Error = "";
            //create a variabe to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 18 years and 1 day
            TestDate = TestDate.AddYears(-20).AddDays(-1);
            //convert the date variable to a string variable
            string CustomerDateOfBirth = TestDate.ToString();
            //invoke method
            Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //show adnaan
        [TestMethod]
        public void CustomerDateOfBirthPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string varaible to store any error message
            String Error = "";
            //create a variabe to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 18 years and plus 1 day
            TestDate = TestDate.AddYears(-20).AddDays(1);
            //convert the date variable to a string variable
            string CustomerDateOfBirth = TestDate.ToString();
            //invoke method
            Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void CustomerDateOfBirthMid()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string varaible to store any error message
            String Error = "";
            //create a variabe to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 18 years and plus 1 day
            TestDate = TestDate.AddYears(-59);
            //convert the date variable to a string variable
            string CustomerDateOfBirth = TestDate.ToString();
            //invoke method
            Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthInvalidDate()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            //set the Dateadded to a non date value
            string CustomerDateOfBirth = "this is not a date!";
            //invoke method
            Error = customer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


    }
}
