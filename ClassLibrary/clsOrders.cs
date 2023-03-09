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
            mOrderNo = 21;
            mOrderDate = Convert.ToDateTime("16/01/2023");
            mCustomerNo = 97;
            mCustomerName = "John Smith";
            mStockNo = 45;
            mStockPrice = 5.99;
            mOrderConfirmed = true;
            return true;
        }
    }
}