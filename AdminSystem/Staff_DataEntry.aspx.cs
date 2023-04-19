using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if(IsPostBack == false)
        {
            if(StaffID != -1)
            {
                DisplayStaff();
            }
        }
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        string StaffId = txtStaffID.Text;
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string DateOfBirth = txtDateOfBirth.Text;
        string StaffDepartment = txtStaffDepartment.Text;
        string Error = "";

        Error = AStaff.Valid(DateOfBirth, FirstName, LastName, StaffDepartment);
        if (Error == "")
        {
            AStaff.StaffID = StaffID;
            AStaff.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            AStaff.FirstName = FirstName;
            AStaff.LastName = LastName;
            AStaff.StaffDepartment = StaffDepartment;
            AStaff.Admin = chkAdmin.Checked;
            clsStaffCollection StaffList = new clsStaffCollection();
            
            if(StaffID == -1)
            {
                StaffList.ThisStaff = AStaff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(StaffID);
                StaffList.ThisStaff = AStaff;
                StaffList.Update();
            }
            Response.Redirect("Staff_List.aspx");
            
        }
        else
        {
            lblError.Text = Error;
        }
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        Int32 StaffId;
        Boolean Found = false;
        StaffId = Convert.ToInt32(txtStaffID.Text);
        Found = AStaff.Find(StaffId);
        if (Found == true)
        {
            txtFirstName.Text = AStaff.FirstName;
            txtLastName.Text = AStaff.LastName;
            txtDateOfBirth.Text = AStaff.DateOfBirth.ToString();
            txtStaffDepartment.Text = AStaff.StaffDepartment;
            chkAdmin.Checked = AStaff.Admin;
        }
    }
}