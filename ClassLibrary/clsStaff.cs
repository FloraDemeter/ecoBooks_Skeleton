using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class clsStaff
    {

        private Int32 mStaffID;

        public Int32 StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }

        private DateTime mDateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }

        private Boolean mAdmin;
        public bool Admin
        {
            get
            {
                return mAdmin;
            }
            set
            {
                mAdmin = value;
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


        public bool Find(int StaffID)
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", StaffID);
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            if (DB.Count == 1)
            {
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["staffDateOfBirth"]);
                mAdmin = Convert.ToBoolean(DB.DataTable.Rows[0]["staffAdmin"]);
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

        public string Valid(string dateOfBirth, string firstName, string lastName, string department)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store values
            DateTime DateTemp;

            try
            {
                DateTemp = Convert.ToDateTime(dateOfBirth);
                if (DateTemp > DateTime.Now.Date.AddYears(-18))
                {
                    Error = Error + "Staff members cannot be under 18 : ";
                }
                if (DateTemp < DateTime.Now.Date.AddYears(-70))
                {
                    Error = Error + "Staff members cannot be over 70 : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }

            //validation for the FirstName field
            if (firstName.Length < 2)
            {
                //record the error
                Error = Error + "The first name must be at least two characters : ";
            }
            if (firstName.Length > 50)
            {
                //record the error
                Error = Error + "The first name must be a maximum of 50 characters : ";
            }

            //validation for the FirstName field
            if (lastName.Length < 2)
            {
                //record the error
                Error = Error + "The last name must be at least two characters : ";
            }
            if (lastName.Length > 50)
            {
                //record the error
                Error = Error + "The last name must be a maximum of 50 characters : ";
            }

            //validation for the FirstName field
            if (department.Length < 2)
            {
                //record the error
                Error = Error + "The department must be at least two characters : ";
            }
            if (department.Length > 50)
            {
                //record the error
                Error = Error + "The department must be a maximum of 50 characters : ";
            }

            return Error;
        }
    }
}