using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass to the method
        string CustomerName = "Yaxye";
        string CustomerEmail = "yaxyeali12@outlook.com";
        string CustomerAddress = "7 Random Street ";
        string DateAdded = DateTime.Now.Date.ToString();

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
            ACustomer.UsernameAvailability = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.UsernameAvailability, TestData);
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

            if (ACustomer.DateAdded != Convert.ToDateTime("16/03/2021"))
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

            if (ACustomer.CustomerAddress != "7 Random Street ")
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

            if (ACustomer.UsernameAvailability != true)
            {
                OK = false;
            }

            //test to see that the result is correct

            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerName = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "a"; //this should be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String CustomerName = "aa"; //this should be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date varaiable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-1);
            //convert the date varaiable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date varaiable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]

        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "this is not a date!";
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerEmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "a"; //this should be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "aa"; //this should be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "a"; //this should be okay
            CustomerEmail = CustomerEmail.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerEmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "a"; //this should be okay
            CustomerEmail = CustomerEmail.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "a"; //this should be okay
            CustomerEmail = CustomerEmail.PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerEmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "a"; //this should be okay
            CustomerEmail = CustomerEmail.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "a"; //this should be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "aa"; //this should be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "a"; //this should be okay
            CustomerAddress = CustomerAddress.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void CustomerAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "a"; //this should be okay
            CustomerAddress = CustomerAddress.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "a"; //this should be okay
            CustomerAddress = CustomerAddress.PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "a"; //this should be okay
            CustomerAddress = CustomerAddress.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
