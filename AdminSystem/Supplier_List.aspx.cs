using System;
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
            DisplaySuppliers();
        }

    }

    void DisplaySuppliers()
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        lstSupplierList.DataSource = Suppliers.SupplierList;
        lstSupplierList.DataValueField = "SupplierNo";
        lstSupplierList.DataTextField = "SupplierName";
        lstSupplierList.DataBind();
    }

    protected void bntEdit_Click(object sender, EventArgs e)
    {
        Int32 SupplierNo;

        if (lstSupplierList.SelectedIndex != -1)
        {
            SupplierNo = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session[" SupplierNo"] = SupplierNo;
            Response.Redirect("Supplier_DataEntry.aspx");
        }
        else
        {
            lblError.Text = " Please select a record to edit form the list";
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierNo"] = -1;
        Response.Redirect("Supplier_DataEntry.aspx");
    }

    protected void bntDelete_Click(object sender, EventArgs e)
    {
        Int32 SupplierNo;
        if (lstSupplierList.SelectedIndex != -1)
        {
            SupplierNo = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["SupplierNo"] = SupplierNo;
            Response.Redirect("Supplier_DataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void lstSupplierList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void bntApply_Click(object sender, EventArgs e)
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        Suppliers.ReportBySupplierName(txtEnteraSupplierName.Text);
        lstSupplierList.DataSource = Suppliers.SupplierList;
        lstSupplierList.DataValueField = "SupplierNo";
        lstSupplierList.DataTextField = "SupplierName";
        lstSupplierList.DataBind();
    }

    protected void bntClear_Click(object sender, EventArgs e)
    {

        clsSupplierCollection Suppliers = new clsSupplierCollection();
        Suppliers.ReportBySupplierName("");
        txtEnteraSupplierName.Text = "";
        lstSupplierList.DataSource = Suppliers.SupplierList;
        lstSupplierList.DataValueField = "SupplierNo";
        lstSupplierList.DataTextField = "SupplierName";
        lstSupplierList.DataBind();
    }
}
