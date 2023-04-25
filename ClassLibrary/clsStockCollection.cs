using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();
        public clsStockCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            PopulateArray(DB);
        }
        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockName", mThisStock.StockName);
            DB.AddParameter("@Description", mThisStock.Description);
            DB.AddParameter("@StockQuantity", mThisStock.StockQuantity);
            DB.AddParameter("@ProcessedDate", mThisStock.ProcessedDate);
            DB.AddParameter("@Available", mThisStock.Available);
            return DB.Execute("sproc_tblStock_Insert");

        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockNo", mThisStock.StockNo);
            DB.AddParameter("@StockName", mThisStock.StockName);
            DB.AddParameter("@Description", mThisStock.Description);
            DB.AddParameter("@StockQuantity", mThisStock.StockQuantity);
            DB.AddParameter("@ProcessedDate", mThisStock.ProcessedDate);
            DB.AddParameter("@Available", mThisStock.Available);
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockNo", mThisStock.StockNo);
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByStockName(string StockName)
        {
            //filters the records based on a full or partial stock name
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockName", StockName);
            DB.Execute("sproc_tblStock_FilterByStockName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mStockList = new List<clsStock>();
            while (Index < RecordCount)
            {
                clsStock aStock = new clsStock();
                aStock.StockNo = Convert.ToInt32(DB.DataTable.Rows[0]["StockNo"]);
                aStock.StockName = Convert.ToString(DB.DataTable.Rows[0]["StockName"]);
                aStock.Description = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                aStock.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["StockQuantity"]);
                aStock.ProcessedDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ProcessedDate"]);
                aStock.Available = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                mStockList.Add(aStock);
                Index++;
            }
        }
    }
}


