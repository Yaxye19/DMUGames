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
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffNo = 1;
            TestItem.Name = "Nathan Hanson";
            TestItem.Email = "nhanson84@gmail.com";
            TestItem.DateOfBirth = Convert.ToDateTime("28/01/1984");
            TestItem.Role = "Sales Support";
            TestItem.HourlyWage = 10.00;
            TestItem.HolidayStatus = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffMemberPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaffMember = new clsStaff();
            //set the properties of the test object
            TestStaffMember.StaffNo = 1;
            TestStaffMember.Name = "Nathan Hanson";
            TestStaffMember.Email = "nhanson84@gmail.com";
            TestStaffMember.DateOfBirth = Convert.ToDateTime("28/01/1984");
            TestStaffMember.Role = "Sales Support";
            TestStaffMember.HourlyWage = 10.00;
            TestStaffMember.HolidayStatus = true;
            //assign the data to the property
            AllStaff.ThisStaffMember = TestStaffMember;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaffMember, TestStaffMember);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffNo = 1;
            TestItem.Name = "Nathan Hanson";
            TestItem.Email = "nhanson84@gmail.com";
            TestItem.DateOfBirth = Convert.ToDateTime("28/01/1984");
            TestItem.Role = "Sales Support";
            TestItem.HourlyWage = 10.00;
            TestItem.HolidayStatus = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffNo = 3;
            TestItem.Name = "Ava Walker";
            TestItem.Email = "AvaWalker@jourrapide.com";
            TestItem.DateOfBirth = Convert.ToDateTime("12/02/1965");
            TestItem.Role = "Receptionist";
            TestItem.HourlyWage = 11.40;
            TestItem.HolidayStatus = false;
            //set ThisStaffMember to the test data
            AllStaff.ThisStaffMember = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //find the record
            AllStaff.ThisStaffMember.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaffMember, TestItem);
        }
    }
}
