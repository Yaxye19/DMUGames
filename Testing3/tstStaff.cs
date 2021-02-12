using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(StaffMember);
        }

        [TestMethod]
        public void StaffNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            StaffMember.StaffNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.StaffNo, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Thomas Tinsley";
            //assign the data to the property
            StaffMember.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.Name, TestData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            StaffMember.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.DateOfBirth, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            string TestData = "The Hawthorns, West Bromwich, West Midlands, B71 4LF";
            //assign the data to the property
            StaffMember.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.Address, TestData);
        }

        [TestMethod]
        public void RolePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Customer Support";
            //assign the data to the property
            StaffMember.Role = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.Role, TestData);
        }

        [TestMethod]
        public void HourlyWagePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            double TestData = 8.90;
            //assign the data to the property
            StaffMember.HourlyWage = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.HourlyWage, TestData);
        }

        [TestMethod]
        public void HolidayStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            StaffMember.HolidayStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.HolidayStatus, TestData);
        }
    }
}
