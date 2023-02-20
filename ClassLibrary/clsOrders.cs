using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public clsOrders()
        {
        }

        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerNo { get; set; }
        public string CustomerName { get; set; }
        public int StockNo { get; set; }
        public double StockPrice { get; set; }
        public bool OrderConfirmed { get; set; }
    }
}