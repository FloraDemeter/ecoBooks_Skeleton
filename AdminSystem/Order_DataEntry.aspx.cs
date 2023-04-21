using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;

    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            if (OrderID != -1)
            {
                DisplayOrders();
            }
        }
    }
    void DisplayOrders()
    {
       /* clsOrderCollection Orders = new clsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "CustomerNo";
        lstOrderList.DataBind();*/
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrders anOrder = new clsOrders();
        string orderDate = txtOrderDate.Text;
        string customerNo = txtCustomerNo.Text;
        string customerName = txtCustomerName.Text;
        string stockNo = txtStockNo.Text;
        string stockPrice = txtStockPrice.Text;
        string orderConfirmed = Convert.ToString(chkOrderConf);
        String Error = "";
        Error = anOrder.Valid(orderDate, customerNo, customerName, stockNo, stockPrice);
        if (Error == "")
        {
            anOrder.OrderID = OrderID;
            anOrder.OrderDate = Convert.ToDateTime(orderDate);
            anOrder.CustomerNo = Convert.ToInt32(customerNo);
            anOrder.CustomerName = customerName;
            anOrder.StockNo = Convert.ToInt32(stockNo);
            anOrder.StockPrice = Convert.ToDouble(stockPrice);
            anOrder.OrderConfirmed = chkOrderConf.Checked;
            clsOrderCollection OrderList = new clsOrderCollection();
            if (OrderID == -1)
            {
                OrderList.ThisOrder = anOrder;
                OrderList.Add();
            } else
            {
                OrderList.ThisOrder.Find(OrderID);
                OrderList.ThisOrder = anOrder;
                OrderList.Update();
            }
            Response.Redirect("Order_List.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Order_List.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrders anOrders = new clsOrders();
        Int32 OrderNo;
        Boolean Found = false;
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
        Found = anOrders.Find(OrderNo);
        if (Found == true)
        {
            txtCustomerName.Text = anOrders.CustomerName;
            txtCustomerNo.Text = anOrders.CustomerNo.ToString();
            txtOrderDate.Text = anOrders.OrderDate.ToString();
            txtStockNo.Text = anOrders.StockNo.ToString();
            txtStockPrice.Text = anOrders.StockPrice.ToString();
            chkOrderConf.Checked = anOrders.OrderConfirmed;
        }

    }
}