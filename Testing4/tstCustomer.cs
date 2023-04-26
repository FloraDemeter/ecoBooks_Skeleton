using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {
        string CustomerFullName = "Shdwman Kareem";
        string CustomerGender = "Male";
        string CustomerAddress = "1,Dobson Close, Wigston, Leicester";
        String CustomerEmailAddress ="shadwman.kareem@gmail.com"
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
        public void CustomerGenderOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACostumer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "Male";
            //assign the data to the property
            ACostumer.CustomerGender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACostumer.CustomerGender, TestData);
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
            Int32 customerID = 1;
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
            Int32 customerID = 1;
            //invole the method
            Found = customer.Find(customerID);
            //check the customer ID
            if (customer.CustomerID != 1)
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
            Int32 customerID = 1;
            //invole the method
            Found = customer.Find(customerID);
            //check the customer ID
            if (customer.CustomerFullName != "Soma")
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
            Int32 customerID = 1;
            //invole the method
            Found = customer.Find(customerID);
            //check the customer ID
            if (customer.CustomerEmailAddress != "Dawn.dmu@gmail.com")
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
            Int32 customerID = 1;
            //invole the method
            Found = customer.Find(customerID);
            //check the customer ID
            if (customer.CustomerDateOfBirth != Convert.ToDateTime("04/10/2001"))
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
            Int32 customerID = 1;
            //invole the method
            Found = customer.Find(customerID);
            //check the customer ID
            if (customer.CustomerAddress != "45, Upperton Road, Leicester")
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
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerID = 1;
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
        public void CustomerGenderFound()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean varibe to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerID = 1;
            //invole the method
            Found = customer.Find(customerID);
            //check the customer ID
            if (customer.CustomerGender != "Male")
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
            Error = customer.Valid(CustomerFullName, CustomerGender, CustomerAddress, CustomerEmailAddress);
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
            Error = customer.Valid(CustomerFullName, CustomerGender, CustomerAddress, CustomerEmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullName()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string CustomerFullName = "a"; //this should trigger an error
                //invoke method
                Error = customer.Valid(CustomerFullName, CustomerGender, CustomerAddress, CustomerEmailAddress);
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
                Error = customer.Valid(CustomerFullName, CustomerGender, CustomerAddress, CustomerEmailAddress);
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
                Error = customer.Valid(CustomerFullName, CustomerGender, CustomerAddress, CustomerEmailAddress);
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
                Error = customer.Valid(CustomerFullName, CustomerGender, CustomerAddress, CustomerEmailAddress);
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
                Error = customer.Valid(CustomerFullName, CustomerGender, CustomerAddress, CustomerEmailAddress);
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
                Error = customer.Valid(CustomerFullName, CustomerGender, CustomerAddress, CustomerEmailAddress);
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
                Error = customer.Valid(CustomerFullName, CustomerGender, CustomerAddress, CustomerEmailAddress);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
        }

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            //String variable to store any message
            string Error = "";
            //create some test data to pass to the method
            string EmailAddress = ""; //this should trigger an error
            //invoke method
            Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMin()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string EmailAddress = "a"; //this should trigger an error
                //invoke method
                Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string EmailAddress = "aa"; //this should trigger an error
                //invoke method
                Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void EmailAddressNoMaxLessOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string EmailAddress = "";
                EmailAddress = EmailAddress.PadRight(49, 'a');
                //invoke method
                Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void EmailAddressMax()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string EmailAddress = "";
                EmailAddress = EmailAddress.PadRight(50, 'a');
                //invoke method
                Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void EmailAddressMid()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string EmailAddress = "";
                EmailAddress = EmailAddress.PadRight(25, 'a');
                //invoke method
                Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string EmailAddress = "";
                EmailAddress = EmailAddress.PadRight(51, 'a');
                //invoke method
                Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
        }

        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            {
                clsCustomer customer = new clsCustomer();
                //String variable to store any message
                string Error = "";
                //create some test data to pass to the method
                string EmailAddress = "";
                EmailAddress = EmailAddress.PadRight(500, 'a');
                //invoke method
                Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
        }

        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string PhoneNumber = "";
                Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
                Assert.AreNotEqual(Error, "");
            }
        }
        [TestMethod]
        public void PhoneNumberMin()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string PhoneNumber = "1";
                Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string PhoneNumber = "11";
                Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void PhoneNumbeMaxLessOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string PhoneNumber = "11111111111";
                Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
                Assert.AreEqual(Error, "");
            }
        }
        [TestMethod]
        public void PhoneNumberMax()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string PhoneNumber = "1111111111111";
                Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string PhoneNumber = "111111111111111";
                Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
                Assert.AreNotEqual(Error, "");
            }
        }

        [TestMethod]
        public void PhoneNumberMid()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string PhoneNumber = "111111";
                Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
                Assert.AreEqual(Error, "");
            }
        }

        [TestMethod]
        public void PhoneNumberExtemeMax()
        {
            {
                clsCustomer customer = new clsCustomer();
                string Error = "";
                string PhoneNumber = "";
                PhoneNumber = PhoneNumber.PadRight(500, '1');
                Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
                Assert.AreNotEqual(Error, "");
            }
        }

        [TestMethod]
        public void DateofBirthExtremeMin()
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
            string DateofBirth = TestDate.ToString();
            //invoke method
            Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateofBirthMinLessOne()
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
            string DateofBirth = TestDate.ToString();
            //invoke method
            Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateofBirthMin()
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
            string DateofBirth = TestDate.ToString();
            //invoke method
            Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateofBirthMinPlusOne()
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
            string DateofBirth = TestDate.ToString();
            //invoke method
            Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateofBirthExtremeMax()
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
            string DateofBirth = TestDate.ToString();
            //invoke method
            Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateofBirthMax()
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
            TestDate = TestDate.AddYears(-18);
            //convert the date variable to a string variable
            string DateofBirth = TestDate.ToString();
            //invoke method
            Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateofBirthMaxLessOne()
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
            TestDate = TestDate.AddYears(-18).AddDays(-1);
            //convert the date variable to a string variable
            string DateofBirth = TestDate.ToString();
            //invoke method
            Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //show adnaan
        [TestMethod]
        public void DateofBirthMaxPlusOne()
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
            TestDate = TestDate.AddYears(-18).AddDays(1);
            //convert the date variable to a string variable
            string DateofBirth = TestDate.ToString();
            //invoke method
            Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void DateofBirthMid()
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
            string DateofBirth = TestDate.ToString();
            //invoke method
            Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidDate()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            //set the Dateadded to a non date value
            string DateofBirth = "this is not a date!";
            //invoke method
            Error = customer.Valid(Name, EmailAddress, PhoneNumber, DateofBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


    }
}
