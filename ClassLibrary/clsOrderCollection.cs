using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
       
        List<clsOrders> mOrderList = new List<clsOrders>();
        clsOrders mThisOrder = new clsOrders();
        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);
        }
        public List<clsOrders> OrderList 
        { 
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            } 
        }
        public clsOrders ThisOrder
        {
            get 
            {
                return mThisOrder;
            }
            set 
            {
                mThisOrder = value;
            } 
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@CustomerNo", mThisOrder.CustomerNo);
            DB.AddParameter("@CustomerName", mThisOrder.CustomerName);
            DB.AddParameter("@StockNo", mThisOrder.StockNo);
            DB.AddParameter("@StockPrice", mThisOrder.StockPrice);
            DB.AddParameter("@OrderConfirmed", mThisOrder.OrderConfirmed);
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@CustomerNo", mThisOrder.CustomerNo);
            DB.AddParameter("@CustomerName", mThisOrder.CustomerName);
            DB.AddParameter("@StockNo", mThisOrder.StockNo);
            DB.AddParameter("@StockPrice", mThisOrder.StockPrice);
            DB.AddParameter("@OrderConfirmed", mThisOrder.OrderConfirmed);
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByCustomerNo(int CustomerNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerNo", CustomerNo);
            DB.Execute("sproc_tblOrder_FilterByCustomerNo");
            PopulateArray(DB);
        }


        public void ReportByOrderID(int OrderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrders>();
            while (Index < RecordCount)
            {
                clsOrders AnOrder = new clsOrders();
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                AnOrder.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                AnOrder.CustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                AnOrder.StockNo = Convert.ToInt32(DB.DataTable.Rows[0]["StockNo"]);
                AnOrder.StockPrice = Convert.ToDouble(DB.DataTable.Rows[0]["StockPrice"]);
                AnOrder.OrderConfirmed = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderConfirmed"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
        }
    }
}