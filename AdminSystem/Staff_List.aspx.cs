﻿using System;
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
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        clsStaffCollection Staff = new clsStaffCollection();
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffID";
        lstStaffList.DataTextField = "FirstName";
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffID"] = -1;
        Response.Redirect("Staff_DataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StaffID;
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffID"] = StaffID;
            Response.Redirect("Staff_DataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StaffID;
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffID"] = StaffID;
            Response.Redirect("Staff_ConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByFirstName(txtFilter.Text);
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "FirstName";
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByFirstName("");
        txtFilter.Text = "";
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "FirstName";
        lstStaffList.DataBind();
    }
}