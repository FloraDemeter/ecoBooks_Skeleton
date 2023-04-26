using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public clsCustomer()
        {
        }

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

        public string mGender { get; private set; }

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
        public bool Find(int OrderNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", CustomerID);
            DB.Execute("sproc_tblOrder_FilterByCustomerID");
            if (DB.Count == 1)
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomeID"]);
                mCustomerDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0][" CustomerDateOfBirth"]);
                mCustomerFullName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFullName"]);
                mGender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mCustomerEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmailAddress"]);

                mCustomerLoyaltyNumber = Convert.ToDouble(DB.DataTable.Rows[0][" CustomerLoyaltyNumber"]);
                return true;
            }
            else
            {
                return false;
            }

        }
        public string Valid(string CustomerID, string CustomerFullName, string CustomerDateOfBirth, string CustomerAddress, string CustomerEmailAddress, string CustomerLoyaltyNumber)
        {

    }
    }
}

