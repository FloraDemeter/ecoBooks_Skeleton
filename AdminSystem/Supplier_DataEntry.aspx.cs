using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 SupplierNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierNo = Convert.ToInt32(Session["SupplierNo"]);
        if (IsPostBack == false)
        {
            if (SupplierNo != -1)
            {
                DisplaySuppliers();
            }
        }
       
    }
    void DisplaySuppliers()
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        Suppliers.ThisSupplier.Find(SupplierNo);
        txtSupplierNo.Text = Suppliers.ThisSupplier.SupplierNo.ToString();
        txtSupplierName.Text = Suppliers.ThisSupplier.SupplierName;
        txtSupplyDate.Text = Suppliers.ThisSupplier.SupplyDate.ToString();
        txtSupplierAddress.Text = Suppliers.ThisSupplier.SupplierAddress;
        txtSupplierContactNo.Text = Suppliers.ThisSupplier.SupplierContactNo.ToString();
        chkUK.Checked = Suppliers.ThisSupplier.UK;
    }   


    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsSupplier AnSupplier = new clsSupplier();
        string SupplierName = txtSupplierName.Text;
        string SupplyDate = txtSupplyDate.Text;
        string SupplierAddress = txtSupplierAddress.Text;
        string SupplierContactNo = txtSupplierContactNo.Text;
        string UK = Convert.ToString(chkUK);
        string Error = "";

        Error = AnSupplier.Valid(SupplierName, SupplyDate, SupplierAddress, SupplierContactNo);
        if (Error == "")
        {
            AnSupplier.SupplierNo = Convert.ToInt32(SupplierNo);
            AnSupplier.SupplierName = SupplierName;
            AnSupplier.SupplyDate = Convert.ToDateTime(SupplyDate);
            AnSupplier.SupplierAddress = SupplierAddress;
            AnSupplier.SupplierContactNo = Convert.ToInt32(SupplierContactNo);
            AnSupplier.UK = chkUK.Checked;
            clsSupplierCollection SupplierList = new clsSupplierCollection();

            if (SupplierNo == -1)
            {
                SupplierList.ThisSupplier = AnSupplier;
                SupplierList.Add();
            }
            else
            {
                SupplierList.ThisSupplier.Find(SupplierNo);
                SupplierList.ThisSupplier = AnSupplier;
                SupplierList.Update();
            }
            Response.Redirect("Supplier_List.aspx");
        }

        else
        {
            lblError.Text = Error;
        }
       
      

    }



    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Supplier_List.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupplier AnSupplier = new clsSupplier();
        Int32 SupplierNo;
        Boolean Found = false;
        SupplierNo = Convert.ToInt32(txtSupplierNo.Text);
        Found = AnSupplier.Find(SupplierNo);
        if (Found == true)
        {
            txtSupplierNo.Text = AnSupplier.SupplierNo.ToString();
            txtSupplierName.Text = AnSupplier.SupplierName;
            txtSupplyDate.Text = AnSupplier.SupplyDate.ToString();
            txtSupplierAddress.Text = AnSupplier.SupplierAddress;
            txtSupplierContactNo.Text = AnSupplier.SupplierContactNo.ToString();
            chkUK.Checked = AnSupplier.UK;


        }
    }
}