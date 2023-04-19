using System;
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
        clsSupplier AnSupplier = new clsSupplier();
        Int32 SupplierNo;
        Boolean Found = false;
        SupplierNo = Convert.ToInt32(txtSupplierNo.Text);
        Found = AnSupplier.Find(SupplierNo);
        if (Found == true )
        {
            txtSupplierNo.Text = AnSupplier.SupplierNo.ToString();
            txtSupplierName.Text = AnSupplier.SupplierName;
            txtSupplyDate.Text = AnSupplier.SupplyDate.ToString();
            txtSupplierAddress.Text = AnSupplier.SupplierAddress;
            txtSupplierContactNo.Text = AnSupplier.SupplierContactNo.ToString();
            chkUK.Checked = AnSupplier.UK;

            
        }
      
        Session["AnSupplier"] = AnSupplier;
        //navigate to the viewer page
        Response.Redirect("Supplier_Viewer.aspx");

    }

    protected void txtSupplierName_TextChanged(object sender, EventArgs e)
    {

    }
}