﻿using System;
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
                mSupplierNo = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierNo"]);
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

        public string Valid(string tstSupplierName, string tstSupplyDate, string tstSupplierAddressOK, string tstSupplierContactNo)
        {
            String Error = " ";
            // SupplyDate
            try
            {
                DateTime DateTemp = Convert.ToDateTime(SupplyDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + " the Supply date cannot be in the past";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The Supply Date cannot be in the future";
                }
            }
            catch
            {
                Error = Error + " The Supply Date was not valid";
            }


            //SupplierName
            if (SupplierName.Length == 0)
            {
                Error = Error + "The SupplierName may not be blank. ";
            }
            if (SupplierName.Length > 50)
            {
                Error = Error + "The SupplierName must be less than 50 characters. ";
            }

            //SupplierAddress
            if (SupplierName.Length == 0)
            {
                Error = Error + "The SupplierAddress may not be blank. ";
            }
            if (SupplierName.Length > 50)
            {
                Error = Error + "The SupplierAddress must be less than 50 characters. ";
            }

            //SupplierContactNo

            {
                if (SupplierContactNo.Length == 0)
                {
                    Error = Error + "The Stock Quantity may not be blank. ";
                }
                if (Convert.ToInt32(SupplierContactNo.Length) > 10)
                {
                    Error = Error + "The Stock Quantity cannot be less than 1. ";
                }
            }



            return Error;

           
        }
    }
}