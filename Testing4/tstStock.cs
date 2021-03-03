using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock GameStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(GameStock);


        }

        [TestMethod]
        public void GameNumberOK()
        {
            //create an instance of the class we want to create
            clsStock GameStock = new clsStock();
            Int32 TestData = 1;
            //assign the data to the property
            GameStock.GameNumber = TestData;
            //test to see that it exists
            Assert.AreEqual(GameStock.GameNumber, TestData);
        }

        [TestMethod]
        public void GameTitleOK()
        {
            //create an instance of the class we want to create
            clsStock GameStock = new clsStock();
            string TestData = " roadrunner ";
            //assign the data to the property
            GameStock.GameTitle = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(GameStock.GameTitle, TestData);
        }


        [TestMethod]
        public void GameDescriptionOK()
        {
            //create an instance of the class we want to create
            clsStock GameStock = new clsStock();
            string TestData = " RUNNING FROM WOLF TO SAVE LIFE  ";
            //assign the data to the property
            GameStock.GameDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(GameStock.GameDescription, TestData);
        }



        [TestMethod]
        public void DateAddedOK()
        {
            //create an instance of the class we want to create
            clsStock GameStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            GameStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(GameStock.DateAdded, TestData);
        }



        [TestMethod]
        public void GamePriceOK()
        {
            //create an instance of the class we want to create
            clsStock GameStock = new clsStock();
            Int32 TestData = 49;
            //assign the data to the property
            GameStock.GamePrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(GameStock.GamePrice, TestData);
        }

        [TestMethod]
        public void GameAvailabilityOK()
        {
            //create an instance of the class we want to create
            clsStock GameStock = new clsStock();
            Boolean TestData = true;
            //assign the data to the property
            GameStock.GameAvailability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(GameStock.GameAvailability, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock GameStock = new clsStock();
            //Bollean variableto store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 GameNumber = 21;
            // invoke the method
            Found = GameStock.Find(GameNumber);
            //test to see if the result is true
            Assert.IsTrue(Found);



        }

        [TestMethod]
        public void TestGameNumberFound()
        {
            //create an instance of the class we want to create
            clsStock GameStock = new clsStock();
            //bollean variableto store the results of the search
            Boolean Found = false;
            //bollean variable to store record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GameNumber = 21;
            // invoke the method
            Found = GameStock.Find(GameNumber);
            //check the address no 
            if (GameStock.GameNumber != 21)
            {
                OK = false;
            }
                   
            //test to see if the result is true
            Assert.IsTrue(OK);



        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStock GameStock = new clsStock();
            //bollean variableto store the results of the search
            Boolean Found = false;
            //bollean variable to store record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DateAddedOK = 21;
            // invoke the method
            Found = GameStock.Find(DateAddedOK);
            //check the address no 
            if (GameStock.DateAdded != Convert.ToDateTime("17/02/2022"))
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);



        }

        [TestMethod]
        public void TestGameTitleFound()
        {
            //create an instance of the class we want to create
            clsStock GameStock = new clsStock();
            //bollean variableto store the results of the search
            Boolean Found = false;
            //bollean variable to store record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GameTitle = 21;
            // invoke the method
            Found = GameStock.Find(GameTitle);
            //check the address no 
            if (GameStock.GameTitle != "road runner")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);



        }


        [TestMethod]
        public void TestGameDescriptionFound()
        {
            //create an instance of the class we want to create
            clsStock GameStock = new clsStock();
            //bollean variableto store the results of the search
            Boolean Found = false;
            //bollean variable to store record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GameDescription = 21;
            // invoke the method
            Found = GameStock.Find(GameDescription);
            //check the address no 
            if (GameStock.GameDescription != "RUNNING FROM WOLF TO SAVE LIFE")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);



        }


        [TestMethod]
        public void TestGamePriceFound()
        {
            //create an instance of the class we want to create
            clsStock GameStock = new clsStock();
            //bollean variableto store the results of the search
            Boolean Found = false;
            //bollean variable to store record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GamePrice = 21;
            // invoke the method
            Found = GameStock.Find(GamePrice);
            //check the address no 
            if (GameStock.GamePrice != 49)
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);



        }

        [TestMethod]
        public void TestGameAvailabilityFound()
        {
            //create an instance of the class we want to create
            clsStock GameStock = new clsStock();
            //bollean variableto store the results of the search
            Boolean Found = false;
            //bollean variable to store record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GameAvailability = 21;
            // invoke the method
            Found = GameStock.Find(GameAvailability);
            //check the address no 
            if (GameStock.GameAvailability !=true)
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);



        }



    }
}
