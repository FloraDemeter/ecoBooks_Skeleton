using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
       
        List<clsOrders> mOrderList = new List<clsOrders>();
        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            RecordCount = DB.Count;
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
        public clsOrders ThisOrder { get; set; }
    }
}