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
            txtCustomerGender.Text = ACustomer.CustomerGender.ToString();
            txtCustomerAddress.Text = ACustomer.CustomerAddress.ToString();
            txtCustomerEmailAddress.Text = ACustomer.CustomerEmailAddress.ToString();
            chkCorrectInformtion.Checked = ACustomer.IHaveGivenCorrectInformation;
        }
   }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Save_Customer_Details.aspx");
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        clsCustomer ACustomer = new clsCustomer();
        string CustomerID = txtCustomerID.Text;
        string CustomerFullName = txtCustomerFullName.Text;
        string CustomerDateOfBirth = txtCustomerDateOfBirth.Text;
        string CustomerGender = txtCustomerGender.Text;
        string CustomerFullAddress = txtCustomerAddress.Text;
        string CustomerEmailAddress = txtCustomerEmailAddress.Text;
        string IHaveGivenCorrectInformation = Convert.ToString(chkCorrectInformtion);
        String Error = "";
        Error = ACustomer.Valid(CustomerID, CustomerFullName, CustomerDateOfBirth, CustomerGender, CustomerFullAddress, CustomerEmailAddress);
        if (Error == "")

            {
                ACustomer.CustomerID = Convert.ToInt32(CustomerID);
                ACustomer.CustomerFullName = Convert.ToString(CustomerFullName);
                ACustomer.CustomerDateOfBirth = Convert.ToDateTime(CustomerDateOfBirth);
                ACustomer.CustomerGender = CustomerGender;
                ACustomer.CustomerAddress = CustomerFullAddress;
                ACustomer.CustomerEmailAddress = CustomerEmailAddress;
              }
            Response.Redirect("Save_Customer_Details.aspx");
        {
            lblError.Text = Error;
        }

    }
}