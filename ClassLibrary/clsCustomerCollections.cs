using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            //get the count of records
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sprox_tblCustomer_SelectALL");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                //creating a blank address
                clsCustomer customer = new clsCustomer();
                //read the fields from the current record
                customer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                customer.CustomerFullName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFullName"]);
                customer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                customer.CustomerEmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmailAddress"]);
                customer.CustomerDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDateOfBirth"]);
                customer.CustomerLoyalty = Convert.ToBoolean(DB.DataTable.Rows[Index]["CustomerLoyalty"]);
                //add the record to the private data member
                mCustomerList.Add(customer);
                //point of the next record
                Index++;
            }

        }

        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        public List<clsCustomer> customerlist
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data 
                mCustomerList = value;
            }
        }
        public clsCustomer thiscustomer { get; set; }
        public int Count
        {
            get { return mCustomerList.Count; }
            set { } //set up later on
        }
   }
}

 