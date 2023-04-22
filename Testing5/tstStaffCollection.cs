using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing5
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.Admin = true;
            TestItem.FirstName = "Sumedh";
            TestItem.LastName = "Singare";
            TestItem.StaffDepartment = "Staff";
            TestItem.StaffID = 9;
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            TestStaff.Admin = true;
            TestStaff.FirstName = "Sumedh";
            TestStaff.LastName = "Singare";
            TestStaff.StaffDepartment = "Staff";
            TestStaff.StaffID = 9;
            TestStaff.DateOfBirth = DateTime.Now.Date;
            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.Admin = true;
            TestItem.FirstName = "Sumedh";
            TestItem.LastName = "Singare";
            TestItem.StaffDepartment = "Staff";
            TestItem.StaffID = 9;
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 1;
            TestItem.Admin = true;
            TestItem.FirstName = "Sumedh";
            TestItem.LastName = "Singare";
            TestItem.StaffDepartment = "Staff";
            TestItem.StaffID = 9;
            TestItem.DateOfBirth = DateTime.Now.Date;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffID = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }



        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.Admin = true;
            TestItem.FirstName = "Sumedh";
            TestItem.LastName = "Singare";
            TestItem.StaffDepartment = "Staff";
            TestItem.DateOfBirth = DateTime.Now.Date;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffID = PrimaryKey;
            //--------------
            TestItem.Admin = true;
            TestItem.FirstName = "Aayush";
            TestItem.LastName = "Moradiya";
            TestItem.StaffDepartment = "Stock";
            TestItem.DateOfBirth = DateTime.Now.Date;
            AllStaff.ThisStaff = TestItem;
            AllStaff.Update();
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff,TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.StaffID = 9;
            TestItem.Admin = true;
            TestItem.FirstName = "Sumedh";
            TestItem.LastName = "Singare";
            TestItem.StaffDepartment = "Staff";
            TestItem.DateOfBirth = DateTime.Now.Date;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffID = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            AllStaff.Delete();
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportsByFirstNameMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByFirstName("");
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByFirstNameNoneFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByFirstName("xxx xxx");
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByFirstNameTestDataFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            Boolean OK = true;
            FilteredStaff.ReportByFirstName("bob");
            if(FilteredStaff.Count == 2)
            {
                if(FilteredStaff.StaffList[0].StaffID != 39)
                {
                    OK = false;
                }
                if(FilteredStaff.StaffList[1].StaffID != 40)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



    }
}
