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
        public string Department
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
            mStaffId = 4;
            mDateAdded = Convert.ToDateTime("28/11/2001");
            mActive = true;
            mFirstName = "Sumedh";
            mLastName = "Singare";
            mDepartment = "Staff";
            return true;
        }
       
    }
}