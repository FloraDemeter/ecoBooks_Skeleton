using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();

        public clsStaffCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            while(Index < RecordCount)
            {
                clsStaff AStaff = new clsStaff();
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[0]["staffID"]);
                AStaff.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["staffDateOfBirth"]);
                AStaff.Admin = Convert.ToBoolean(DB.DataTable.Rows[0]["staffAdmin"]);
                AStaff.FirstName = Convert.ToString(DB.DataTable.Rows[0]["staffFirstName"]);
                AStaff.LastName = Convert.ToString(DB.DataTable.Rows[0]["staffLastName"]);
                AStaff.StaffDepartment = Convert.ToString(DB.DataTable.Rows[0]["staffDepartment"]);
                mStaffList.Add(AStaff);
                Index++;
            }
        }
        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {
                //later
            }
        }
        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@staffFirstName", mThisStaff.FirstName);
            DB.AddParameter("@staffLastName", mThisStaff.LastName);
            DB.AddParameter("@staffDateOfBirth", mThisStaff.DateOfBirth);
            DB.AddParameter("@staffDepartment", mThisStaff.StaffDepartment);
            DB.AddParameter("@staffAdmin", mThisStaff.Admin);
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@staffID", mThisStaff.StaffID);
            DB.AddParameter("@staffFirstName", mThisStaff.FirstName);
            DB.AddParameter("@staffLastName", mThisStaff.LastName);
            DB.AddParameter("@staffDateOfBirth", mThisStaff.DateOfBirth);
            DB.AddParameter("@staffDepartment", mThisStaff.StaffDepartment);
            DB.AddParameter("@staffAdmin", mThisStaff.Admin);
            DB.Execute("sproc_tblStaff_Update");
        }
    }
}