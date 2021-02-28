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
            ACustomer.UserNameAvailability = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.UserNameAvailability, TestData);
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

            string TestData = "7 Random Street";

            //assign the data to the property

            ACustomer.CustomerAddress = TestData;

            //test to see that the two values are the same

            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }

        [TestMethod]

        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property

            Int32 TestData = 1;

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
      
        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //Boolean variable to store the results of the validation

            Boolean Found = false;

            //create some test data to use with the method

            Int32 CustomerID = 1;

            //invoke the method

            Found = ACustomer.Find(CustomerID);

            //test to see if the result is true 

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            
            clsCustomer ACustomer = new clsCustomer();

            //boolean variable to store the result of the search

            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)

            Boolean OK = true;

            //create some test data to use with the method

            Int32 CustomerID = 1;

            //invoke the method

            Found = ACustomer.Find(CustomerID);

            //check the address

            if (ACustomer.CustomerID != 1)
            {
                OK = false;
            }

            //test to see that the result is correct

            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //boolean variable to store the result of the search

            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)

            Boolean OK = true;

            //create some test data to use with the method

            Int32 CustomerID = 1;

            //invoke the method

            Found = ACustomer.Find(CustomerID);

            //check the address

            if (ACustomer.DateAdded != Convert.ToDateTime("15/02/2021"))
            {
                OK = false;
            }

            //test to see that the result is correct

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //boolean variable to store the result of the search

            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)

            Boolean OK = true;

            //create some test data to use with the method

            Int32 CustomerID = 1;

            //invoke the method

            Found = ACustomer.Find(CustomerID);

            //check the property

            if (ACustomer.CustomerEmail != "yaxyeali12@outlook.com")
            {
                OK = false;
            }

            //test to see that the result is correct

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //boolean variable to store the result of the search

            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)

            Boolean OK = true;

            //create some test data to use with the method

            Int32 CustomerID = 1;

            //invoke the method

            Found = ACustomer.Find(CustomerID);

            //check the property

            if (ACustomer.CustomerName != "Yaxye")
            {
                OK = false;
            }

            //test to see that the result is correct

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //boolean variable to store the result of the search

            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)

            Boolean OK = true;

            //create some test data to use with the method

            Int32 CustomerID = 1;

            //invoke the method

            Found = ACustomer.Find(CustomerID);

            //check the property

            if (ACustomer.CustomerAddress != "7 Random Street")
            {
                OK = false;
            }

            //test to see that the result is correct

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUserNameAvailabilityFound()
        {
            //create an instance of the class we want to create

            clsCustomer ACustomer = new clsCustomer();

            //boolean variable to store the result of the search

            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)

            Boolean OK = true;

            //create some test data to use with the method

            Int32 CustomerID = 1;

            //invoke the method

            Found = ACustomer.Find(CustomerID);

            //check the property

            if (ACustomer.UserNameAvailability != true)
            {
                OK = false;
            }

            //test to see that the result is correct

            Assert.IsTrue(OK);
        }

    }
}
