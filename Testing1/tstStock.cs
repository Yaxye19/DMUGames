﻿using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
	[TestClass]
	public class tstStock
	{
		[TestMethod]
		public void InstanceOK()
		{
            //create an instance of the class we want to create
            ClsStock GameStock = new ClsStock();
            //test to see that it exists
            Assert.IsNotNull(GameStock);
   
        }

        [TestMethod]
        public void GameNumberOK()
        {
            //create an instance of the class we want to create
            ClsStock GameStock = new ClsStock();
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
            ClsStock GameStock = new ClsStock();
            string TestData = " roadrunner ";
            //assign the data to the property
            GameStock.Title = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(GameStock.Title, TestData);
        }



        [TestMethod]
        public void DateAddedOK()
        {
            //create an instance of the class we want to create
            ClsStock GameStock = new ClsStock();
            DateTime TestData = DateTime.Now17/02/2021;
            //assign the data to the property
            GameStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(GameStock.DateAdded, TestData);
        }

        [TestMethod]
        public void GamePriceOK()
        {
            //create an instance of the class we want to create
            ClsStock GameStock = new ClsStock();
            Price TestData = 
            //assign the data to the property
            GameStock.GamePrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(GameStock.GamePrice, TestData);
        }


        [TestMethod]
        public void GameAvailabilityOK ()
        {
            //create an instance of the class we want to create
            ClsStock GameStock = new ClsStock();
            Boolean TestData = true;
            //assign the data to the property
            GameStock.GameAvailability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(GameStock.GameAvilability, TestData);
        }









    }






}
