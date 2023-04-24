﻿using System;
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
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "CustomerNo";
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1;
        Response.Redirect("Order_DataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("Order_DataEntry.aspx");
        } else
        {
            lblError.Text = "Please select a record to edit from the list.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("Order_ConfirmDelete.aspx");
        } else
        {
            lblError.Text = "Please select a record to delete from the list.";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByCustomerNo(Convert.ToInt32(txtFilterCustNo.Text));
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "CustomerNo";
        lstOrderList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        txtFilterCustNo.Text = "";
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "CustomerNo";
        lstOrderList.DataBind();
    }

    protected void btnApplyOrder_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByOrderID(Convert.ToInt32(txtFilterOrderID.Text));
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "CustomerNo";
        lstOrderList.DataBind();
    }

    protected void btnClearOrder_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        txtFilterOrderID.Text = "";
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "CustomerNo";
        lstOrderList.DataBind();
    }
}