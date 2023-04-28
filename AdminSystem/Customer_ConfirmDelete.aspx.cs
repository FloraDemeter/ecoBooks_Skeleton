using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.thiscustomer.Find(CustomerID);
        CustomerBook.Delete();
        Response.Redirect("Customer_List.aspx");


    }
}