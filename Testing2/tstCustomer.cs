using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]

        public void UserNameAvailabilityOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            ACustomer.Active = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            ACustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateAdded, TestData);
        }

        [TestMethod]

        public void CustomerAddressPropertyOK()
        {
            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property

            Int32 TestData = 1;

            //assign the data to the property

            ACustomer.Address = TestData;

            //test to see that the two values are the same

            Assert.AreEqual(ACustomer.Address, TestData);
        }

        [TestMethod]

        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property

            int TestData = 1;

            //assign the data to the property

            ACustomer.CustomerID = TestData;

            //test to see that the two values are the same

            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]

        public void CustomerNamePropertyOK()
        {
            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property

            string TestData = "Yaxye";

            //assign the data to the property

            ACustomer.CustomerName = TestData;

            //test to see that the two values are the same

            Assert.AreEqual(ACustomer.CustomerName, TestData);
        }

        [TestMethod]

        public void CustomerEmailOK()

        {
            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property

            string TestData = "yaxye12@outlook.com";

            //assign the data to the property

            ACustomer.CustomerEmail = TestData;

            //test to see that the two values are the same

            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

    }
}
