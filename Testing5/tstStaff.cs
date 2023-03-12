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
            AStaff.StaffFirstName = TestData;
            Assert.AreEqual(AStaff.StaffFirstName, TestData);
        }

        [TestMethod]
        public void StaffLastNamePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "Last Name";
            AStaff.StaffLastName = TestData;
            Assert.AreEqual(AStaff.StaffLastName, TestData);
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


    }
}
