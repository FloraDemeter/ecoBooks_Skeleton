using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public clsOrders()
        {
        }

        private Int32 mOrderNo;
        public Int32 CustomerID 
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
        public Int32 CustomerNo
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
                mStockPrice = Convert.ToDouble(DB.DataTable.Rows[0]["StockPrice"]);
                mOrderConfirmed = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderConfirmed"]);
                return true;
            }
            else
            {
                return false;
            }

        }

        public string Valid(string orderDate, string customerNo, string customerName, string stockNo, string stockPrice)
        {
            String Error = "";
            //order date
            try
            {
                DateTime DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The Order Date cannot be in the past. ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The Order Date cannot be in the future. ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date. ";
            }
            //customerNo
            try
            {
                if (customerNo.Length == 0)
                {
                    Error = Error + "The Customer No. may not be blank. ";
                }
                if (Convert.ToInt32(customerNo) < 1)
                {
                    Error = Error + "The Customer No. cannot be less than 1. ";
                }
            }
            catch
            {
                Error = Error + "The Customer No. was not a valid date. ";
            }
            //customerName
            if (customerName.Length == 0)
            {
                Error = Error + "The Customer Name may not be blank. ";
            }
            if (customerName.Length > 50)
            {
                Error = Error + "The Customer Name must be less than 50 characters. ";
            }
            //stockNo
            try
            {
                if (stockNo.Length == 0)
                {
                    Error = Error + "The Stock No. may not be blank. ";
                }
                if (Convert.ToInt32(stockNo) < 1)
                {
                    Error = Error + "The Stock No. cannot be less than 1. ";
                }
            }
            catch
            {
                Error = Error + "The Stock No. was not a valid date. ";
            }
            //stockPrice
            try
            {
                if (Convert.ToDouble(stockPrice) < 0.00)
                {
                    Error = Error + "The Stock Price cannot be less than 0. ";
                }
            }
            catch
            {
                Error = Error + "The Stock Price was not a valid data type. ";
            }

            return Error;
        }
    }
}