using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    private object lblError;

    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsSupplier AnSupplier = new clsSupplier();

        string SupplierNo = txtSupplierNo.Text;
        string SupplierName = txtSupplierName.Text;
        string SupplyDate = txtSupplyDate.Text;
        string SupplierAddress = txtSupplierAddress.Text;
        string SupplierContactNo = txtSupplierContactNo.Text;
        string Error = " ";
        Error = AnSupplier.Valid(SupplierNo,SupplierName,SupplierAddress,SupplierContactNo,SupplyDate );
        if (Error == "")
        {
            AnSupplier.SupplierNo = Convert.ToInt32(txtSupplierNo.Text);
            AnSupplier.SupplierName = txtSupplierName.Text;
            AnSupplier.SupplyDate = Convert.ToDateTime(txtSupplyDate.Text);
            AnSupplier.SupplierAddress = Convert.ToString(txtSupplierAddress.Text);
            AnSupplier.SupplierContactNo = Convert.ToInt32(txtSupplierContactNo.Text);
            AnSupplier.UK = Convert.ToBoolean(chkUK);
            Session["AnSupplier"] = AnSupplier;
            //navigate to the viewer page
            Response.Redirect("Supplier_Viewer.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
        

    }

    protected void txtSupplierName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        clsSupplier AnSupplier = new clsSupplier();
        Int32 SupplierNo;
        Boolean Found = false;
        SupplierNo = Convert.ToInt32(txtSupplierNo.Text);
        Found = AnSupplier.Find(SupplierNo);
        if (Found == true)
        {


            txtSupplierName.Text = AnSupplier.SupplierName;
            txtSupplierAddress.Text = AnSupplier.SupplierAddress;
            txtSupplierContactNo.Text = AnSupplier.SupplierContactNo.Text;
        }
    }
}