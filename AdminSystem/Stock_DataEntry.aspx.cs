using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrabry;


public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock aStock = new clsStock();
        
        aStock.StockNo = Convert.ToInt32(txtStockNo.Text);
        aStock.StockName = txtStockName.Text;
        aStock.Description = txtDescription.Text;
        aStock.StockQuantity = Convert.ToInt32(txtStockQuantity.Text);
        aStock.ProcessedDate = Convert.ToDateTime(txtProcessedDate.Text);
        aStock.Available = Convert.ToBoolean(chkAvailable);
        Session["aStock"] = aStock;
        //navigate to the viewer page
        Response.Redirect("Stock_Viewer.aspx");


    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Order_List.aspx");
    }
}