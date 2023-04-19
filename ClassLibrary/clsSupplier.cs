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
            mSupplierNo = 3;
            mSupplierName = "Costcutter";
            mSupplyDate = Convert.ToDateTime("14/02/2023");
            mUK = true;
            mSupplierAddress = "Leeds";
            mSupplierContactNo = 9876674;


            return true;
        }
    }
}