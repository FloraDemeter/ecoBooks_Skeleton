using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrders anOrder = new clsOrders();
        anOrder = (clsOrders)Session["anOrder"];
        Response.Write(anOrder.OrderID);
        Response.Write(anOrder.OrderDate);
        Response.Write(anOrder.CustomerNo);
        Response.Write(anOrder.CustomerName);
        Response.Write(anOrder.StockNo);
        Response.Write(anOrder.StockPrice);
    }
}