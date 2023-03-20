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
        clsStaff AStaff = new clsStaff();
        string StaffId = txtStaffId.Text;
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string DateOfBirth = txtDateOfBirth.Text;
        string StaffDepartment = txtStaffDepartment.Text;
        string Error = "";
        if (Error == "")
        {
            AStaff.FirstName = FirstName;
            AStaff.LastName = LastName;
            AStaff.DateAdded = Convert.ToDateTime(DateOfBirth);
            AStaff.StaffDepartment = StaffDepartment;
            Session["AStaff"] = AStaff;
            Response.Write("Staff_Viewer.aspx");
        }
        {
            lblError.Text = Error;
        }
    }


    protected void btnFind_Click1(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        Int32 StaffId;
        Boolean Found = false;
        StaffId = Convert.ToInt32(txtStaffId.Text);
        Found = AStaff.Find(StaffId);
        if (Found == true)
        {
            txtFirstName.Text = AStaff.FirstName;
            txtLastName.Text = AStaff.LastName;
            txtDateOfBirth.Text = AStaff.DateAdded.ToString();
            txtStaffDepartment.Text = AStaff.StaffDepartment;
            chkAdmin.Checked = AStaff.Active;
        }
    }
}