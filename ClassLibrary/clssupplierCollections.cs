using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clssupplierCollection
    {
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        clsSupplier mThisSupplier = new clsSupplier();



        public clssupplierCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_SelectAll");
            RecordCount = DBNull.Count;
            while(Index < RecordCount)
            {
                clsSupplier AnSupplier = new clsSupplier();
                AnSupplier.SupplierNo = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierNo"]);
                AnSupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                AnSupplier.SupplyDate = Convert.ToDateTime(DB.DataTable.Rows[0]["SupplyDate"]);
                AnSupplier.UK = Convert.ToBoolean(DB.DataTable.Rows[0]["UK"]);
                AnSupplier.SupplierAddress = Convert.ToString(DB.DataTable.Rows[0]["SupplierAddress"]);
                AnSupplier.SupplierContactNo = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierContactNo"]);
                mSupplierList.Add(AnSupplier);
                Index++;
            }
        }
        public List<clsSupplier> SupplierList
        {
            get
            {
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
            }
        }
        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {
                //LATER
            }
        }
        public clsSupplier clsSupplier
        {
            get
            {
                return mThisSupplier;

            }
            set
            {
                mThisSupplier = value;
            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Addparameter("@supplierName", mThisSupplier.SupplierName);
            DB.Addparameter("@supplyDate", mThisSupplier.SupplyDate);
            DB.Addparameter("@supplierAddress", mThisSupplier.SupplierAddress);
            DB.Addparameter("@supplierContactNo", mThisSupplier.SupplierContactNo);
            DB.Addparameter("@UK", mThisSupplier.UK);
            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Addparameter("@supplierNo", mThisSupplier.SupplierNo);
            DB.Addparameter("@supplierName", mThisSupplier.SupplierName);
            DB.Addparameter("@supplyDate", mThisSupplier.SupplyDate);
            DB.Addparameter("@supplierAddress", mThisSupplier.SupplierAddress);
            DB.Addparameter("@supplierContactNo", mThisSupplier.SupplierContactNo);
            DB.Addparameter("@UK", mThisSupplier.UK);
            DB.Execute("sproc_tblSupplier_Update");
        }

    }

}