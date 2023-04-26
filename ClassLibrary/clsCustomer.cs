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
        public Int32 CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }

        private DateTime mCustomerDateOfBirth;
        public DateTime CustomerDateOfBirth
        {
            get
            {
                return mCustomerDateOfBirth;
            }
            set
            {
                mCustomerDateOfBirth = value;
            }
        }



        private string mCustomerFullName;

        public string mGender { get;  set; }

        public string CustomerFullName
        {
            get
            {
                return mCustomerFullName;
            }
            set
            {
                mCustomerFullName = value;
            }
        }

        private String mCustomerGender;
        public String CustomerGender
        {
            get
            {
                return mCustomerGender;
            }
            set
            {
                mCustomerGender = value;
            }
        }
        private String mCustomerAddress;
        public String CustomerAddress
        {
            get
            {
                return mCustomerAddress;
            }
            set
            {
                mCustomerAddress = value;
            }
        }


        private double mCustomerLoyaltyNumber;
        public double CustomerLoyaltyNumber
        {
            get
            {
                return mCustomerLoyaltyNumber;
            }
            set
            {
                mCustomerLoyaltyNumber = value;
            }
        }

        private String mCustomerEmailAddress;
        public String CustomerEmailAddress
        {
            get
            {
                return mCustomerEmailAddress;
            }
            set
            {
                mCustomerEmailAddress = value;
            }
        }
        public bool Find(int CustomerID)
        {
            return true;
        }
        public string Valid( string CustomerFullName, string CustomerDateOfBirth, string CustomerAddress, string CustomerEmailAddress, string CustomerLoyaltyNumber, string CustomerGender)
        {
            String Error = "";

            try
                //DateOfBirth
            {
                DateTime DateTemp = Convert.ToDateTime(CustomerDateOfBirth);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The CustomerDateOfBirth cannot be in the past. ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The CustomerDateOfBirth cannot be in the future. ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date. ";
            }


            //FullName
            if (CustomerFullName.Length == 0)
            {
                Error = Error + "The CustomerFullName may not be blank. ";
            }
            if (CustomerFullName.Length > 50)
            {
                Error = Error + "The CustomerFullName must be less than 50 characters. ";
            }

            //Address
            if (CustomerAddress.Length == 0)
            {
                Error = Error + "The CustomerAddress may not be blank. ";
            }
            if (CustomerAddress.Length > 50)
            {
                Error = Error + "The CustomerAddress must be less than 50 characters. ";
            }

            //EmailAddress
            if (CustomerEmailAddress.Length == 0)
            {
                Error = Error + "The CustomerEmailAddress may not be blank. ";
            }
            if (CustomerEmailAddress.Length > 50)
            {
                Error = Error + "The CustomerEmailAddress must be less than 50 characters. ";
            }


            //Gender

            if (CustomerGender.Length == 0)
            {
                Error = Error + "The CustomerGender may not be blank. ";
            }
            if (CustomerGender.Length > 50)
            {
                Error = Error + "The Gender must be less than 10 characters. ";
            }


            //LoyaltyNumber
            try
            {
                if (Convert.ToDouble(CustomerLoyaltyNumber) < 0.00)
                {
                    Error = Error + "The Stock Price cannot be less than 0. ";
                }
            }
            catch
            {
                Error = Error + "Customer Loyalty Number was not a valid data type. ";
            }

            return Error;
        }

    }
    }
