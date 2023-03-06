﻿using System;
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
        clsOrders anOrder = new clsOrders();
        anOrder.OrderID = Convert.ToInt32(txtOrderNo.Text);
        anOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        anOrder.CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
        anOrder.CustomerName = txtCustomerName.Text;
        anOrder.StockNo = Convert.ToInt32(txtStockNo.Text);
        anOrder.StockPrice = Convert.ToDouble(txtStockPrice.Text);
        //anOrder.OrderConfirmed = Convert.ToBoolean(chkOrderConf);
        Session["anOrder"] = anOrder;
        Response.Redirect("Order_Viewer.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Order_List.aspx");
    }
}