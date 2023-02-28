namespace ClassLibrary
{
    public class clsStock
    {
        public clsStock()
        {
        }

        public int StockNo { get; set; }
        public string StockName { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }
        public System.DateTime ProcessedDate { get; set; }
        public bool Available { get; set; }
    }
}
