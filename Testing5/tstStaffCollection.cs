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

      /*
        [TestMethod]
        public void CountPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Int32 SomeCount = 2;
            AllStaff.Count = SomeCount;
            Assert.AreEqual(AllStaff.Count, SomeCount);
        }
      */

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

      /*
        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.AreEqual(AllStaff.Count, 2);
        }
      */
        
       
        
        /*
        //constructor of the class
        public clsStaffCollection()
        {
            clsStaff TestItem = new clsStaff();
            TestItem.Admin = true;
            TestItem.FirstName = "Sumedh";
            TestItem.LastName = "Singare";
            TestItem.StaffDepartment = "Staff";
            TestItem.StaffID = 9;
            TestItem.DateOfBirth = DateTime.Now.Date;
            mStaffList.Add(TestItem);
            TestItem.Admin = true;
            TestItem.FirstName = "Aayush";
            TestItem.LastName = "Moradiya";
            TestItem.StaffDepartment = "Stock";
            TestItem.StaffID = 4;
            TestItem.DateOfBirth = DateTime.Now.Date;
            mStaffList.Add(TestItem);
        }
        */

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
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


    }
}
