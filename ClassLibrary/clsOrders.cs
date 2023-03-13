using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public clsOrders()
        {
        }

        private Int32 mOrderNo;
        public Int32 OrderID 
        {
            get 
            {
                return mOrderNo;
            }
            set
            {
                mOrderNo = value;
            }
        }
       
        private DateTime mOrderDate;
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }
        
        private Int32 mCustomerNo;
        public int CustomerNo
        {
            get
            {
                return mCustomerNo;
            }
            set
            {
                mCustomerNo = value;
            }
        }
        
        private string mCustomerName;
        public string CustomerName
        {
            get
            {
                return mCustomerName;
            }
            set
            {
                mCustomerName = value;
            }
        }
        
        private Int32 mStockNo;
        public int StockNo
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
        
        private double mStockPrice;
        public double StockPrice
        {
            get
            {
                return mStockPrice;
            }
            set
            {
                mStockPrice = value;
            }
        }
        
        private bool mOrderConfirmed;
        public bool OrderConfirmed
        {
            get
            {
                return mOrderConfirmed;
            }
            set
            {
                mOrderConfirmed = value;
            }
        }

        public bool Find(int OrderNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderNo);
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            if (DB.Count == 1)
            {
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mStockNo = Convert.ToInt32(DB.DataTable.Rows[0]["StockNo"]);
                mStockPrice = Convert.ToDouble(DB.DataTable.Rows[0]["StockPriceNo"]);
                mOrderConfirmed = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderConfirmed"]);
                return true;
            } else {
                return false;
            }
            
        }
    }
}