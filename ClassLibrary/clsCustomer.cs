using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerID;
        public int CustomerID
        {
            get { return mCustomerID; }
            set { mCustomerID = value; }
        }

        private String mCustomerFullName;
        public string CustomerFullName
        {
            get { return mCustomerFullName; }
            set { mCustomerFullName = value; }
        }

        private DateTime mCustomerDateOfBirth;
        public DateTime CustomerDateOfBirth
        {
            get { return mCustomerDateOfBirth; }
            set { mCustomerDateOfBirth = value; }
        }

        private String mCustomerAddress;
        public string CustomerAddress
        {
            get { return mCustomerAddress; }
            set { mCustomerAddress = value; }
        }

        private String mCustomerEmailAddress;
        public string CustomerEmailAddress
        {
            get { return mCustomerEmailAddress; }
            set { mCustomerEmailAddress = value; }
        }


        private Boolean mCustomerLoyalty;
        public bool CustomerLoyalty
        {
            get { return mCustomerLoyalty; }
            set { mCustomerLoyalty = value; }
        }

        public bool Find(int customerID)
        {

            //create an instance of the data conneection
            clsDataConnection db = new clsDataConnection();
            //add the parameter for the CustomerID to search for
            db.AddParameter("@CustomerID", customerID);
            //execite the stored procedure
            db.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero!)
            if (db.Count == 1)
            {
                //saved data fromt he database to data members
                mCustomerID = Convert.ToInt32(db.DataTable.Rows[0]["CustomerID"]);
                mCustomerFullName = Convert.ToString(db.DataTable.Rows[0]["CustomerFullName"]);
                mCustomerDateOfBirth = Convert.ToDateTime(db.DataTable.Rows[0]["CustomerDateOfBirth"]);
                mCustomerAddress = Convert.ToString(db.DataTable.Rows[0]["CustomerAddress"]);
                mCustomerEmailAddress = Convert.ToString(db.DataTable.Rows[0]["CustomerEmailAddress"]);
                mCustomerLoyalty = Convert.ToBoolean(db.DataTable.Rows[0]["CustomerLoyalty"]);
                //return that everything worked
                return true;
            }
            //if no record was found
            else
            { return false; }//indicates a issue

        }

        public string Valid(string CustomerFullName, string CustomerAddress, string CustomerEmailAddress, string CustomerDateOfBirth)
        {
            //create a string variable to store the error
            String Error = "";
            DateTime DateTemp;
            //if the CustomerFullName is blank
            if (CustomerFullName.Length == 0)
            {
                //record error
                Error = Error + "The Customer Full Name may not be blank : ";
            }
            //if the Customer Full Name is greater than 50 characters
            if (CustomerFullName.Length > 50)
            {
                //record error
                Error = Error + "The Customer Full Name must be less than 50 characters : ";
            }
            //if the CustomerAddress is blank
            if (CustomerAddress.Length == 0)
            {
                Error = Error + "The Customer Address may not the blank.";

            }
            if (CustomerAddress.Length > 50)
            {
                Error = Error + "The CustomerAddress  must be less than 50 characters.";
            }
            //if the CustomerEmailAddress is blank
            if (CustomerEmailAddress.Length == 0)
            {
                //record error
                Error = Error + "The Customer Email Address may not be blank : ";
            }
            //if the Customer Email Address is greater than 50 characters
            if (CustomerEmailAddress.Length > 50)
            {
                //record error
                Error = Error + "The Customer Email Address must be less than 50 characters : ";
            }
            try
            {
                //copy the DateofBirth value to the DateTemp varaible
                DateTemp = Convert.ToDateTime(CustomerDateOfBirth);
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    //record error
                    Error = Error + "The date cannot be less than 100 years in the past ";
                }
                if (DateTemp > DateTime.Now.Date.AddYears(-20))
                {
                    //record error
                    Error = Error + "The CustomerDateOfBirth must be over 16 years in the past ";
                }


            }
            catch
            { //return any error messages
                Error = Error + "The date was not a valid date ";
            }
            return Error;

        }
    }
}