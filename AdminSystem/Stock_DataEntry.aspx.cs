using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock aStock = new clsStock();
        
        string StockNo = txtStockNo.Text;
        string StockName = txtStockName.Text;
        string Description = txtDescription.Text;
        string StockQuantity = txtStockQuantity.Text;
        string ProcessedDate = txtProcessedDate.Text;
        string Available = Convert.ToString(chkAvailable);
        string Error = "";
        Error = aStock.Valid(StockNo, );
        if (Error == "")
        {
            aStock.StockNo = Convert.ToInt32(txtStockNo.Text);
            aStock.StockName = txtStockName.Text;
            aStock.Description = txtDescription.Text;
            aStock.StockQuantity = Convert.ToInt32(txtStockQuantity.Text);
            aStock.ProcessedDate = Convert.ToDateTime(txtProcessedDate.Text);
            aStock.Available = Convert.ToBoolean(chkAvailable);
            Session["aStock"] = aStock;
            Response.Redirect("Stock_Viewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }


    }
    

protected void btnCancel_Click(object sender, EventArgs e)
    {
        clsStock aStock = new clsStock();
        Int32 StockNo;
        Boolean Found = false;
        StockNo = Convert.ToInt32(txtStockNo.Text);
        Found = aStock.Find(StockNo);
        if (Found == true)
        {
           

            txtStockName.Text = aStock.StockName;
            txtDescription.Text = aStock.Description;
            txtStockQuantity.Text = aStock.StockQuantity.ToString;
        }

    }
}