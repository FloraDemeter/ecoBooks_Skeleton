﻿using System;
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
        AnSupplier.SupplierNo = txtSupplierNo.Text;
        Session["AnSupplier"] = AnSupplier;
        //navigate to the viewer page
        Response.Redirect("Supplier_Viewer.aspx");

    }
}