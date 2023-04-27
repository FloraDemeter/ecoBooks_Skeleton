using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        Int32 CustomerID;
        Boolean Found = false;
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        Found = ACustomer.Find(CustomerID);
        if (Found == true)
        {
            ;
        }

        {
            txtCustomerID.Text = ACustomer.CustomerID.ToString();
            txtCustomerFullName.Text = ACustomer.CustomerFullName.ToString();
            txtCustomerDateOfBirth.Text = ACustomer.CustomerDateOfBirth.ToString();
            txtCustomerAddress.Text = ACustomer.CustomerAddress.ToString();
            txtCustomerEmailAddress.Text = ACustomer.CustomerEmailAddress.ToString();

        }
   }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Customer_List.aspx");
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        clsCustomer ACustomer = new clsCustomer();
        string CustomerID = txtCustomerID.Text;
        string CustomerFullName = txtCustomerFullName.Text;
        string CustomerDateOfBirth = txtCustomerDateOfBirth.Text;
        string CustomerFullAddress = txtCustomerAddress.Text;
        string CustomerEmailAddress = txtCustomerEmailAddress.Text;
        String Error = "";
        Error = ACustomer.Valid(CustomerFullName, CustomerFullAddress, CustomerEmailAddress, CustomerDateOfBirth);
        if (Error == "")
            {
            ACustomer.CustomerFullName = Convert.ToString(CustomerFullName);
            ACustomer.CustomerDateOfBirth = Convert.ToDateTime(CustomerDateOfBirth);
            ACustomer.CustomerAddress = CustomerFullAddress;
            ACustomer.CustomerEmailAddress = CustomerEmailAddress;
            Session["ACustomer"] = ACustomer;
            Response.Write("Customer_Viewer.aspx");
            }
        else        
        {
            lblError.Text = Error;
        }

    }
}