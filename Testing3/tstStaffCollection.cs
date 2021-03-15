using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing3
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
            TestItem.Name = "Nathan Hanson";
            TestItem.Email = "nhanson84@gmail.com";
            TestItem.DateOfBirth = Convert.ToDateTime("28/01/1984");
            TestItem.Role = "Sales Support";
            TestItem.HourlyWage = 10.00;
            TestItem.HolidayStatus = true;
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffMemberPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaffMember = new clsStaff();
            TestStaffMember.Name = "Nathan Hanson";
            TestStaffMember.Email = "nhanson84@gmail.com";
            TestStaffMember.DateOfBirth = Convert.ToDateTime("28/01/1984");
            TestStaffMember.Role = "Sales Support";
            TestStaffMember.HourlyWage = 10.00;
            TestStaffMember.HolidayStatus = true;
            AllStaff.ThisStaffMember = TestStaffMember;
            Assert.AreEqual(AllStaff.ThisStaffMember, TestStaffMember);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.Name = "Nathan Hanson";
            TestItem.Email = "nhanson84@gmail.com";
            TestItem.DateOfBirth = Convert.ToDateTime("28/01/1984");
            TestItem.Role = "Sales Support";
            TestItem.HourlyWage = 10.00;
            TestItem.HolidayStatus = true;
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
    }
}
