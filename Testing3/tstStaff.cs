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
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            string TestData = "thomas.tinsley@testmail.com";
            //assign the data to the property
            StaffMember.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.Email, TestData);
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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffNo = 17;
            //invoke the method
            Found = StaffMember.Find(StaffNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffNoFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 17;
            //invoke the method
            Found = StaffMember.Find(StaffNo);
            //check the staff no
            if (StaffMember.StaffNo != 17)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 17;
            //invoke the method
            Found = StaffMember.Find(StaffNo);
            //check the property
            if (StaffMember.Name != "Tom Tinsley")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 17;
            //invoke the method
            Found = StaffMember.Find(StaffNo);
            //check the property
            if (StaffMember.Email != "tom.tinsley@testmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 17;
            //invoke the method
            Found = StaffMember.Find(StaffNo);
            //check the property
            if (StaffMember.DateOfBirth != Convert.ToDateTime("01/01/2000"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRoleFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 17;
            //invoke the method
            Found = StaffMember.Find(StaffNo);
            //check the property
            if (StaffMember.Role != "Manager")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHourlyWageFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 17;
            //invoke the method
            Found = StaffMember.Find(StaffNo);
            //check the property
            if (StaffMember.HourlyWage != 12.60)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHolidayStatusFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 17;
            //invoke the method
            Found = StaffMember.Find(StaffNo);
            //check the property
            if (StaffMember.HolidayStatus != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
