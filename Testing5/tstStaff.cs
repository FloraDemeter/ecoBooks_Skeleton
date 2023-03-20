using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstStaff
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
            AStaff.Active = TestData;
            Assert.AreEqual(AStaff.Active, TestData);
        }

        [TestMethod]
        public void StaffDateOfBirthPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AStaff.DateAdded = TestData;
            Assert.AreEqual(AStaff.DateAdded, TestData);

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
            Assert.AreEqual(AStaff.StaffDepartment, TestData);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Int32 TestData = 1;
            AStaff.StaffId = TestData;
            Assert.AreEqual(AStaff.StaffId, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffId = 4;
            Found = AStaff.Find(StaffId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 4;
            Found = AStaff.Find(StaffId);
            if (AStaff.StaffId != 4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 4;
            Found = AStaff.Find(StaffId);
            if(AStaff.DateAdded !=Convert.ToDateTime("28/11/2001"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 4;
            Found = AStaff.Find(StaffId);
            if (AStaff.Active != true)
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
            Int32 StaffId = 4;
            Found = Astaff.Find(StaffId);
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
            Int32 StaffId = 4;
            Found = AStaff.Find(StaffId);
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
            Int32 StaffId = 4;
            Found = AStaff.Find(StaffId);
            if(AStaff.StaffDepartment != "Stock")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }

    }
