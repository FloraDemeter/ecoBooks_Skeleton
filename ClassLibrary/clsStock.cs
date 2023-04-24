using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsStock
    {
        public clsStock()
        {
        }
        //private data member for active
        private Int32 mStockNo;
        public Int32 StockNo 
        {
            get 
            {
                return mStockNo;
            }
            set
            {
                mStockNo = value;
            }
        }

        private string mStockName;
        public string StockName
        {
            get
            {
                return mStockName;
            }
            set
            {
                mStockName = value;
            }
        }

        private string mDescription;
        public string Description
        {
            get
            {
                return mDescription;
            }
            set
            {
                mDescription = value;
            }
        }

        private Int32 mStockQuantity;
        public int StockQuantity
        {
            get
            {
                return mStockQuantity;
            }
            set
            {
                mStockQuantity = value;
            }
        }

        private DateTime mProcessedDate;
        public DateTime ProcessedDate
        {
            get
            {
                return mProcessedDate;
            }
            set
            {
                mProcessedDate = value;
            }
        }
        
        private bool mAvailable;
        public bool Available
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }

        public bool Find(int StockNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockNo", StockNo);
            DB.Execute("sproc_tblStock_FilterByStockNo");
            if (DB.Count == 1)
            {
                mStockNo = Convert.ToInt32(DB.DataTable.Rows[0]["StockNo"]);
                mStockName = Convert.ToString(DB.DataTable.Rows[0]["StockName"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["StockQuantity"]);
                mProcessedDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ProcessedDate"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                return true;
            } else {
                return false;
            }
            
        }

        public string Valid(string StockName, string Description, string StockQuantity, string ProcessedDate)
        {
            String Error = "";
            //Processed date
            try
            {
                DateTime DateTemp = Convert.ToDateTime(ProcessedDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The ProcessedDate cannot be in the past. ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The ProcessedDate cannot be in the future. ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date. ";
            }
            
           //StockName
            if (StockName.Length == 0)
            {
                Error = Error + "The Stock Name may not be blank. ";
            }
            if (StockName.Length > 50)
            {
                Error = Error + "The Stock Name must be less than 50 characters. ";
            }
            //StockQuantity
            try
            {
                if (StockQuantity.Length == 0)
                {
                    Error = Error + "The Stock Quantity may not be blank. ";
                }
                if (Convert.ToInt32(StockQuantity) < 1)
                {
                    Error = Error + "The Stock Quantity cannot be less than 1. ";
                }
            }
            catch
            {
                Error = Error + "The Stock Quantity was not a valid date. ";
            }
            //Description
            if (Description.Length == 0)
            {
                Error = Error + "The Description may not be blank. ";
            }
            if (Description.Length > 50)
            {
                Error = Error + "The Description must be less than 50 characters. ";
            }

            return Error;
        }
    }
}
