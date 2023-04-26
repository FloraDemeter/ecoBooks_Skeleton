using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 SupplierNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierNo = Convert.ToInt32(Session["Supplier"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        SupplierBook.ThisSupplier.Find(SupplierNo);
        SupplierBook.Delete();
        Response.Redirect("Supplier_List.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Supplier_List.aspx");

    }
}