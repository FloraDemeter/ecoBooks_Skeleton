using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class clssupplierCollection
    {

        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        clsSupplier mThisSupplier = new clsSupplier();



        public clssupplierCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
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
            DB.AddParameter("@supplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@supplyDate", mThisSupplier.SupplyDate);
            DB.AddParameter("@supplierAddress", mThisSupplier.SupplierAddress);
            DB.AddParameter("@supplierContactNo", mThisSupplier.SupplierContactNo);
            DB.AddParameter("@UK", mThisSupplier.UK);
            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@supplierNo", mThisSupplier.SupplierNo);
            DB.AddParameter("@supplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@supplyDate", mThisSupplier.SupplyDate);
            DB.AddParameter("@supplierAddress", mThisSupplier.SupplierAddress);
            DB.AddParameter("@supplierContactNo", mThisSupplier.SupplierContactNo);
            DB.AddParameter("@UK", mThisSupplier.UK);
            DB.Execute("sproc_tblSupplier_Update");
        }

    }

    public class clsSupplierCollection
    {
        public List<clsSupplier> SupplierList { get; set; }
        
        public clsSupplier ThisSupplier { get; set; }
        public int Count { get; set; }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@supplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@supplyDate", mThisSupplier.SupplyDate);
            DB.AddParameter("@supplierAddress", mThisSupplier.SupplierAddress);
            DB.AddParameter("@supplierContactNo", mThisSupplier.SupplierContactNo);
            DB.AddParameter("@UK", mThisSupplier.UK);
            return DB.Execute("sproc_tblSupplier_Insert");


        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierNo", mboxThisSupplier.SupplierNo);
            DB.Execute("sproc_tblSupplier_Delete");
        }

        public void ReportBySupplierName(string v)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierName", SupplierName);
            DB.Execute("sproc_tblSupplier_FilterBySupplierName");
            PopulateArry(DB);
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@supplierNo", mThisSupplier.SupplierNo);
            DB.AddParameter("@supplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@supplyDate", mThisSupplier.SupplyDate);
            DB.AddParameter("@supplierAddress", mThisSupplier.SupplierAddress);
            DB.AddParameter("@supplierContactNo", mThisSupplier.SupplierContactNo);
            DB.AddParameter("@UK", mThisSupplier.UK);
            DB.Execute("sproc_tblSupplier_Update");
           
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mSupplierList = new List<clsSupplier>();
            while (Index < RecordCount)
            {
                clsSupplieAnSupplier.SupplierNo = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierNo"]);
                AnSupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                AnSupplier.SupplyDate = Convert.ToDateTime(DB.DataTable.Rows[0]["SupplyDate"]);
                AnSupplier.UK = Convert.ToBoolean(DB.DataTable.Rows[0]["UK"]);
                AnSupplier.SupplierAddress = Convert.ToString(DB.DataTable.Rows[0]["SupplierAddress"]);
                AnSupplier.SupplierContactNo = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierContactNo"]);
                mSupplierList.Add(AnSupplier);
                Index++;
            }
        }
    }
}
