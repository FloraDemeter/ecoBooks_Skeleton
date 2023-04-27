using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mCustomerDetails = new clsCustomer();
        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);
        }
        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {

            }
        }
        public clsCustomer CustomerDetails
        {
            get
            {
                return mCustomerDetails;
            }
            set
            {
                mCustomerDetails = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerDateOfBirth", mCustomerDetails.CustomerDateOfBirth);
            DB.AddParameter("@CustomerFullName", mCustomerDetails.CustomerFullName);
            DB.AddParameter("@CustomerID", mCustomerDetails.CustomerID);
            DB.AddParameter("@CustomerGender", mCustomerDetails.CustomerGender);
            DB.AddParameter("@CustomerAddress", mCustomerDetails.CustomerAddress);
            DB.AddParameter("@CustomerEmailAddress", mCustomerDetails.CustomerEmailAddress);
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mCustomerDetails.CustomerID);
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByCustomerNo(int CustomerNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerNo", CustomerNo);
            DB.Execute("sproc_tblOrder_FilterByCustomerNo");
            PopulateArray(DB);
        }


        public void ReportByOrderID(int OrderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
            while (Index < RecordCount)
            {
                clsCustomer AnOrder = new clsCustomer();
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.CustomerDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDateOfBirth"]);
                ACustomer.CustomerGender = Convert.ToString(DB.DataTable.Rows[Index]["CustomerGender"]);
                ACustomer.CustomerFullName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFullName"]);
                ACustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                ACustomer.CustomerLoyaltyNumber = Convert.ToDouble(DB.DataTable.Rows[Index]["CustomerLoyaltyNumber"]);
                ACustomer.CustomerEmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmailAddress"]);
                mCustomerList.Add(AnOrder);
                Index++;
            }
        }
    }
}

