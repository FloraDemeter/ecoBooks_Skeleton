using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 StockNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        StockNo = Convert.ToInt32(Session["StockNo"]);
    }



    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStockCollection StockBook = new clsStockCollection();
        StockBook.ThisStock.Find(StockNo);
        StockBook.Delete();
        Response.Redirect("Stock_List.aspx");


    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Stock_List.aspx");
    }
}