﻿using System;
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

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.Name = "Smack Trench";
            TestItem.Email = "djtenchy@blueyonder.co.uk";
            TestItem.DateOfBirth = Convert.ToDateTime("31/08/2000");
            TestItem.Role = "Plumber";
            TestItem.HourlyWage = 10.00;
            TestItem.HolidayStatus = true;

            AllStaff.ThisStaffMember = TestItem;

            PrimaryKey = AllStaff.Add();
            TestItem.StaffNo = PrimaryKey;
            //modify the test data
            TestItem.Name = "Jack Tench";
            TestItem.Email = "itstenchy@yahoo.com";
            TestItem.DateOfBirth = Convert.ToDateTime("01/09/2000");
            TestItem.Role = "Plumbers Assistant";
            TestItem.HourlyWage = 8.00;
            TestItem.HolidayStatus = false;

            AllStaff.ThisStaffMember = TestItem;
            AllStaff.Update();
            AllStaff.ThisStaffMember.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaffMember, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffNo = 175;
            TestItem.Name = "John Smith";
            TestItem.Email = "temp@email.com";
            TestItem.DateOfBirth = Convert.ToDateTime("01/01/01");
            TestItem.Role = "N/A";
            TestItem.HourlyWage = 10.00;
            TestItem.HolidayStatus = true;
            //set ThisStaffMember to the test data
            AllStaff.ThisStaffMember = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //find the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaffMember.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaffMembers = new clsStaffCollection();
            //apply a blank string (should return all records)
            FilteredStaffMembers.ReportByName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaffMembers.Count);
        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaffMembers = new clsStaffCollection();
            //apply a name that doesn't exist
            FilteredStaffMembers.ReportByName("McLovin");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaffMembers.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaffMembers = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a name that doesn't exist
            FilteredStaffMembers.ReportByName("Isaac");
            //check that the correct number of records are found
            if (FilteredStaffMembers.Count == 1)
            {
                //check that the record is ID 7
                if (FilteredStaffMembers.StaffList[0].StaffNo != 7)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
