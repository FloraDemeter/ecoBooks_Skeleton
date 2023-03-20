using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class clsStaff
    {

        private Int32 mStaffId;

        public Int32 StaffId
        {
            get
            {
                return mStaffId;
            }
            set
            {
                mStaffId = value;
            }
        }

        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }

        private Boolean mActive;
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        private string mFirstName;
        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }

        private string mLastName;
        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }

        private string mDepartment;
        public string StaffDepartment
        {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }
        }


        public bool Find(int StaffId)
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", StaffId);
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            if (DB.Count == 1)
            {
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["staffId"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["staffDateOfBirth"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["staffAdmin"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["staffFirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["staffLastName"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["staffDepartment"]);
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}