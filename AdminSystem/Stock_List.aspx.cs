using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStocks();
        }
    }

    void DisplayStocks()
    {
        clsStockCollection Stocks = new clsStockCollection();
        lstStockList.DataSource = Stocks.StockList;
        lstStockList.DataValueField = "StockNo";
        lstStockList.DataTextField = "StockName";
        lstStockList.DataBind();

    }

    protected void lstStockList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StockNo"] = -1;
        Response.Redirect("Stock_DataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StockNo;
        if (lstStockList.SelectedIndex != -1)
        {
            StockNo = Convert.ToInt32(lstStockList.SelectedValue);
            Session["StockNo"] = StockNo;
            Response.Redirect("Stock_DataEntry.aspx");

        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StockNo;
        if (lstStockList.SelectedIndex != -1)
        {
            StockNo = Convert.ToInt32(lstStockList.SelectedValue);
            Session["StockNo"] = StockNo;
            Response.Redirect("Stock_ConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection Stocks = new clsStockCollection();
        Stocks.ReportByStockName(txtEnteraStockname.Text);
        lstStockList.DataSource = Stocks.StockList;
        lstStockList.DataValueField = "StockNo";
        lstStockList.DataTextField = "StockName";
        lstStockList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Stocks = new clsStockCollection();
        Stocks.ReportByStockName("");
        txtEnteraStockname.Text = "";
        lstStockList.DataSource = Stocks.StockList;
        lstStockList.DataValueField = "StockNo";
        lstStockList.DataTextField = "StockName";
        lstStockList.DataBind();
    }
}