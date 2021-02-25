using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing1
{​​​​​​​
    [TestClass]
    public class tstStock
    {​​​​​​​
        [TestMethod]
        public void InstanceOK()
        {​​​​​​​
            //create an instance of the class we want to create
            clsStock GameStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(GameStock);


        }​​​​​​​


        [TestMethod]
        public void GameNumberOK()
        {​​​​​​​
            //create an instance of the class we want to create
            clsStock GameStock = new clsStock();
            Int32 TestData = 1;
            //assign the data to the property
            GameStock.GameNumber = TestData;
            //test to see that it exists
            Assert.AreEqual(GameStock.GameNumber, TestData);
        }​​​​​​​


        [TestMethod]
        public void GameTitleOK()
        {​​​​​​​
            //create an instance of the class we want to create
            clsStock GameStock = new clsStock();
            string TestData = " roadrunner ";
            //assign the data to the property
            GameStock.GameTitle = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(GameStock.GameTitle, TestData);
        }​​​​​​​




        [TestMethod]
        public void DateAddedOK()
        {​​​​​​​
            //create an instance of the class we want to create
            clsStock GameStock = new clsStock();
            DateTime TestData = DateTime.Now(17 / 02 / 2022);
            //assign the data to the property
            GameStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(GameStock.DateAdded, TestData);
        }​​​​​​​


        [TestMethod]
        public void GamePriceOK()
        {​​​​​​​
            //create an instance of the class we want to create
            clsStock GameStock = new clsStock();
            Int32 TestData = 49;
            //assign the data to the property
            GameStock.GamePrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(GameStock.GamePrice, TestData);
        }​​​​​​​



        [TestMethod]
        public void GameAvailabilityOK()
        {​​​​​​​
            //create an instance of the class we want to create
            clsStock GameStock = new clsStock();
            Boolean TestData = true;
            //assign the data to the property
            GameStock.GameAvailability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(GameStock.GameAvailability, TestData);
        }​​​​​​​


        [TestMethod]
        public void FindMethodOK()
        {​​​​​​​
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


        }​​​​​​​








    }​​​​​​​

































