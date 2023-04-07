using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class Staff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AStaff = new clsStaff();
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffAdminPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean TestData = true;
            AStaff.Admin = TestData;
            Assert.AreEqual(AStaff.Admin, TestData);
        }

        [TestMethod]
        public void StaffDateOfBirthPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AStaff.DateOfBirth = TestData;
            Assert.AreEqual(AStaff.DateOfBirth, TestData);

        }

        [TestMethod]
        public void StaffFirstNamePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "First Name";
            AStaff.FirstName = TestData;
            Assert.AreEqual(AStaff.FirstName, TestData);
        }

        [TestMethod]
        public void StaffLastNamePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "Last Name";
            AStaff.LastName = TestData;
            Assert.AreEqual(AStaff.LastName, TestData);
        }

        [TestMethod]
        public void StaffDepartmentPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "Department";
            AStaff.StaffDepartment = TestData;
            AStaff.StaffDepartment = TestData;
            Assert.AreEqual(AStaff.StaffDepartment, TestData);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Int32 TestData = 1;
            AStaff.StaffID = TestData;
            Assert.AreEqual(AStaff.StaffID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffID = 4;
            Found = AStaff.Find(StaffID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TesaffIdFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 4;
            Found = AStaff.Find(StaffID);
            if (AStaff.StaffID != 4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 4;
            Found = AStaff.Find(StaffID);
            if(AStaff.DateOfBirth !=Convert.ToDateTime("28/11/2001"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAdminFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 4;
            Found = AStaff.Find(StaffID);
            if (AStaff.Admin != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        
        [TestMethod]
        public void TestFirstNameFound()
        {
            clsStaff Astaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 4;
            Found = Astaff.Find(StaffID);
            if(Astaff.FirstName != "Aayush")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 4;
            Found = AStaff.Find(StaffID);
            if(AStaff.LastName != "Moradiya")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDepartmentFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 4;
            Found = AStaff.Find(StaffID);
            if(AStaff.StaffDepartment != "Stock")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        string DateOfBirth = DateTime.Now.Date.AddYears(-20).ToString();
        string FirstName = "Aayush";
        string LastName = "Moradiya";
        string Department = "Stock";
        
        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string DateOfBirth = DateTime.Today.AddYears(-200).ToString();
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string DateOfBirth = DateTime.Today.AddYears(-17).ToString();
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string DateOfBirth = DateTime.Today.AddYears(-18).ToString();
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string DateOfBirth = DateTime.Today.AddYears(-19).ToString();
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string DateOfBirth = DateTime.Today.AddYears(-69).ToString();
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string DateOfBirth = DateTime.Today.AddYears(-70).ToString();
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string DateOfBirth = DateTime.Today.AddYears(-71).ToString();
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string DateOfBirth = DateTime.Today.AddYears(-44).ToString();
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string DateOfBirth = DateTime.Today.AddYears(200).ToString();
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string DateOfBirth = "not a date";
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameExtremeMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string FirstName = "";
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string FirstName = "a";
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string FirstName = "aa";
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string FirstName = "aaa";
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(49, 'a');
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(50, 'a');
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(25, 'a');
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(200, 'a');
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameExtremeMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String LastName = "";
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String LastName = "a";
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String LastName = "aa";
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String LastName = "aaa";
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String LastName = "";
            LastName = LastName.PadRight(49, 'a');
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String LastName = "";
            LastName = LastName.PadRight(50, 'a');
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String LastName = "";
            LastName = LastName.PadRight(25, 'a');
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String LastName = "";
            LastName = LastName.PadRight(200, 'a');
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDepartmentExtremeMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Department = "";
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDepartmentMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Department = "a";
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDepartmentMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Department = "aa";
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDepartmentMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Department = "aaa";
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDepartmentMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Department = "";
            Department = Department.PadRight(49, 'a');
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDepartmentMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Department = "";
            Department = Department.PadRight(50, 'a');
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDepartmentMid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Department = "";
            Department = Department.PadRight(25, 'a');
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDepartmentExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Department = "";
            Department = Department.PadRight(200, 'a');
            Error = AStaff.Valid(DateOfBirth, FirstName, LastName, Department);
            Assert.AreNotEqual(Error, "");
        }
    }
}
