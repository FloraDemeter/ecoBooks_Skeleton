using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StockNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        StockNo = Convert.ToInt32(Session["StockNo"]);
        if (IsPostBack == false)
        {
            if (StockNo != -1)
            {
                DisplayStocks();
            }
        }
    }

    void DisplayStocks()
    {
        clsStockCollection Stocks = new clsStockCollection();
        Stocks.ThisStock.Find(StockNo);
        txtStockNo.Text = Stocks.ThisStock.StockNo.ToString();
        txtStockName.Text = Stocks.ThisStock.StockName;
        txtDescription.Text = Stocks.ThisStock.Description;
        txtStockQuantity.Text = Stocks.ThisStock.StockQuantity.ToString();
        txtProcessedDate.Text = Stocks.ThisStock.ProcessedDate.ToString();
        chkAvailable.Checked = Stocks.ThisStock.Available;
    }



    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock aStock = new clsStock();
        string StockName = txtStockName.Text;
        string Description = txtDescription.Text;
        string StockQuantity = txtStockQuantity.Text;
        string ProcessedDate = txtProcessedDate.Text;
        string Available = Convert.ToString(chkAvailable);
        string Error = "";

        Error = aStock.Valid(StockName, Description, StockQuantity, ProcessedDate);
        if (Error == "")
        {
            aStock.StockNo = Convert.ToInt32(StockNo);
            aStock.StockName = StockName;
            aStock.Description = Description;
            aStock.StockQuantity = Convert.ToInt32(StockQuantity);
            aStock.ProcessedDate = Convert.ToDateTime(ProcessedDate);
            aStock.Available = chkAvailable.Checked;
            clsStockCollection StockList = new clsStockCollection();

            if (StockNo == -1)
            {
                StockList.ThisStock = aStock;
                StockList.Add();
            }

            else
            {
                StockList.ThisStock.Find(StockNo);
                StockList.ThisStock = aStock;
                StockList.Update();
            }
            Response.Redirect("Stock_List.aspx");
        }
        
        
        else
        {
            lblError.Text = Error;
        }


    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Stock_List.aspx");

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock aStock = new clsStock();
        // variable to store the primary key
        Int32 StockNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StockNo = Convert.ToInt32(txtStockNo.Text);
        //find the record
        Found = aStock.Find(StockNo);
        if (Found == true)
        {
            // display the values of the properties in the form
            txtStockName.Text = aStock.StockName;
            txtDescription.Text = aStock.Description;
            txtStockQuantity.Text = aStock.StockQuantity.ToString();
            txtProcessedDate.Text = aStock.ProcessedDate.ToString();
            chkAvailable.Checked = aStock.Available;
        }
    }
}