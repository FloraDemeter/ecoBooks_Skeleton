using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            if (CustomerID != -1)
            {
                DisplayCustomer();
            }

        }
    }

     void DisplayCustomer()
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.thiscustomer.Find(CustomerID);
        txtCustomerID.Text = CustomerBook.thiscustomer.CustomerID.ToString();
        txtCustomerAddress.Text = CustomerBook.thiscustomer.CustomerAddress;
        txtCustomerEmailAddress.Text = CustomerBook.thiscustomer.CustomerEmailAddress;
        txtCustomerFullName.Text = CustomerBook.thiscustomer.CustomerFullName;
        txtCustomerDateOfBirth.Text = CustomerBook.thiscustomer.CustomerDateOfBirth.ToString();
        chkCustomerLoyalty.Checked = CustomerBook.thiscustomer.CustomerLoyalty;

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
        string CustomerFullName = txtCustomerFullName.Text;
        string CustomerDateOfBirth = txtCustomerDateOfBirth.Text;
        string CustomerAddress = txtCustomerAddress.Text;
        string CustomerEmailAddress = txtCustomerEmailAddress.Text;
        String Error = "";
        Error = ACustomer.Valid(CustomerFullName, CustomerAddress, CustomerEmailAddress, CustomerDateOfBirth);
        if (Error == "")
        {
            ACustomer.CustomerID = CustomerID;
            ACustomer.CustomerFullName = CustomerFullName;
            ACustomer.CustomerDateOfBirth = Convert.ToDateTime(CustomerDateOfBirth);
            ACustomer.CustomerAddress = CustomerAddress;
            ACustomer.CustomerEmailAddress = CustomerEmailAddress;
            ACustomer.CustomerLoyalty = chkCustomerLoyalty.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();


            if (CustomerID == -1)
            {
                CustomerList.thiscustomer = ACustomer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.thiscustomer.Find(CustomerID);
                CustomerList.thiscustomer = ACustomer;
                CustomerList.Update();
            }
            Response.Redirect("CustomerBookList.aspx");
        }

        else        
        {
            lblError.Text = Error;
        }

    }



    protected void txtCustomerAddress_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtCustomerID_TextChanged(object sender, EventArgs e)
    {

    }
}