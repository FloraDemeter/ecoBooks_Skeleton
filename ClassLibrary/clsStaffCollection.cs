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
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);
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
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@staffFirstName", mThisStaff.FirstName);
            DB.AddParameter("@staffLastName", mThisStaff.LastName);
            DB.AddParameter("@staffDateOfBirth", mThisStaff.DateOfBirth);
            DB.AddParameter("@staffDepartment", mThisStaff.StaffDepartment);
            DB.AddParameter("@staffAdmin", mThisStaff.Admin);
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByFirstName(string FirstName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FirstName", FirstName);
            DB.Execute("sproc_tblStaff_FilterByFirstName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();
            while(Index < RecordCount)
            {
                clsStaff AStaff = new clsStaff();
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["staffDateOfBirth"]);
                AStaff.Admin = Convert.ToBoolean(DB.DataTable.Rows[Index]["staffAdmin"]);
                AStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["staffFirstName"]);
                AStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["staffLastName"]);
                AStaff.StaffDepartment = Convert.ToString(DB.DataTable.Rows[Index]["staffDepartment"]);
                mStaffList.Add(AStaff);
                Index++;
            }
 
        }
    }
}