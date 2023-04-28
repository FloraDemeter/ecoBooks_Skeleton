using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //constructor
        public clsCustomerCollection()
        {
            {
                //object fpr the class
                clsDataConnection DB = new clsDataConnection();
                DB.Execute("sproc_tblCustomer_SelectAll");
                PopulateArray(DB);
            }
        }
        void PopulateArray(clsDataConnection db)
        {
            //populates the array list based on the data table
            {
                Int32 Index = 0;
                Int32 RecordCount = 0;
                //get the count of records
                clsDataConnection DB = new clsDataConnection();
                DB.Execute("sproc_tblCustomer_SelectALL");
                RecordCount = DB.Count;
                while (Index < RecordCount)
                {
                    //creating a blank address
                    clsCustomer Customer = new clsCustomer();
                    //read the fields from the current record
                    Customer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                    Customer.CustomerFullName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFullName"]);
                    Customer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                    Customer.CustomerEmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmailAddress"]);
                    Customer.CustomerDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDateOfBirth"]);
                    Customer.CustomerLoyalty = Convert.ToBoolean(DB.DataTable.Rows[Index]["CustomerLoyalty"]);
                    //add the record to the private data member
                    mCustomerList.Add(Customer);
                    //point of the next record
                    Index++;
                }


            }
        }

            List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mthiscustomer = new clsCustomer();

        public List<clsCustomer> customerlist
        {
            get { return mCustomerList; }
            set { mCustomerList = value; }
        }
        public int Count
        {
            get { return mCustomerList.Count; }
            set { } //set up later on
        }
        public clsCustomer thiscustomer
        {
            get { return mthiscustomer; }
            set { mthiscustomer = value; }
        }

        public int Add()
        {
            mthiscustomer.CustomerID = 2;
            return mthiscustomer.CustomerID;

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerFullName", mthiscustomer.CustomerFullName);
            DB.AddParameter("@CustomerDateOfBirth", mthiscustomer.CustomerDateOfBirth);
            DB.AddParameter("@CustomerAddress", mthiscustomer.CustomerAddress);
            DB.AddParameter("@CustomerEmailAddress", mthiscustomer.CustomerEmailAddress);
            DB.AddParameter("@CustomerLoyalty", mthiscustomer.CustomerLoyalty);

            return DB.Execute("sproc_tblCustomer_Insert");
        }


        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mthiscustomer.CustomerID);
            DB.Execute("sproc_tblCustomer_Delete");
        }


        public void Update()
        {
            //adds a new record to the database vased on the values of mthiscustomer;
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramteers for the record procedure
            DB.AddParameter("@CustomerID", mthiscustomer.CustomerID);
            DB.AddParameter("@CustomerFullName", mthiscustomer.CustomerFullName);
            DB.AddParameter("@CustomerDateOfBirth", mthiscustomer.CustomerDateOfBirth);
            DB.AddParameter("@CustomerAddress", mthiscustomer.CustomerAddress);
            DB.AddParameter("@CustomerEmailAddress", mthiscustomer.CustomerEmailAddress);
            DB.AddParameter("@CustomerLoyalty", mthiscustomer.CustomerLoyalty);
            DB.Execute("sproc_tblCustomer_Update");
        }


        public void ReportByName(string Name)
        {
            //filter the records based on a full or partial post code
            clsDataConnection db = new clsDataConnection();
            //send the name parameter to the database
            db.AddParameter("@Name", Name);
            //execute the stored procedure
            db.Execute("sproc_tblCustomer_FilterByName");
            //populate the array list with the data table
            PopulateArray(db);
        }

        public void ReportByCustomerFullName(string CustomerFullName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("CustomerFullName", CustomerFullName);
                DB.Execute("sproc_tblCustomer_FilterByCustomerFullName.");

        }
    }
}

