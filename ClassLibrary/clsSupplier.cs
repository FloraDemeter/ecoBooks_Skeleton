using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsSupplier
    {
        private Int32 mSupplierNo;
        public int SupplierNo
        {
            get
            {
                return mSupplierNo;
            }
            set
            {
                mSupplierNo = value;
            }
        }
        private string mSupplierName;
        public string SupplierName
        {
            get
            {
                return mSupplierName;
            }
            set
            {
                mSupplierName = value;
            }
        }
        private DateTime mSupplyDate;
        public DateTime SupplyDate
        {
            get
            {
                return mSupplyDate;
            }
            set
            {
                mSupplyDate = value;
            }
        }

       

        private bool mUK;
        public bool UK
        {
            get
            {
                return mUK;
            }
            set
            {
                mUK = value;
            }
        }
        private string mSupplierAddress;
        public string SupplierAddress
        {
            get
            {
                return mSupplierAddress;
            }
            set
            {
                mSupplierAddress = value;
            }
        }
        private Int32 mSupplierContactNo;
        public int SupplierContactNo
        {
            get
            {
                return mSupplierContactNo;
            }
            set
            {
                mSupplierContactNo = value;
            }
        }

   
        public bool Find(int supplierNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierNo", SupplierNo);
            DB.Execute("sproc_tblSupplier_FillterByAupplierNo");
            if (DB.Count == 1)
            {
                mSupplierNo = Convert.ToInt32(DB.DataTable.Rows[0]["Supplier"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mSupplyDate = Convert.ToDateTime(DB.DataTable.Rows[0]["SupplyDate"]);
                mUK = Convert.ToBoolean(DB.DataTable.Rows[0]["UK"]);
                mSupplierAddress = Convert.ToString(DB.DataTable.Rows[0]["SupplierAddress"]);
                mSupplierContactNo = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierContactNo"]);

               
                return true;
            }
             else
            {
                return false;
            }
        }
    }
}