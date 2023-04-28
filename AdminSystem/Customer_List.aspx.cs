using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayCustomer();
        }
        CustomerID = Convert.ToInt32(Session["CustomerID"]);

    }

    void DisplayCustomer()
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        lstCustomerlist.DataSource = Customer.customerlist;
        lstCustomerlist.DataValueField = "CustomerID";
        lstCustomerlist.DataTextField = "CustomerFullName";
        lstCustomerlist.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerID"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;
        if (lstCustomerlist.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomerlist.SelectedValue);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";

        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;
        if (lstCustomerlist.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomerlist.SelectedValue);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("Customer_ConfirmDelete.aspx");
        }
        else

        {
            btnDelete.Text = "Please select a record to delete from the list";
        }
    }
}

        
  