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
        clsStock aStock = new clsStock();
        aStock = (clsStock)Session["aStock"];
        Response.Write(aStock.StockName + "<br />");
        Response.Write(aStock.Description + "<br />");
        Response.Write(aStock.StockQuantity + "<br />");
        Response.Write(aStock.ProcessedDate + "<br />");
        Response.Write(aStock.Available + "<br />");
        
        
    }
}