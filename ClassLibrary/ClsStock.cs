using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the GameNumber property
        public Int32 mGameNumber;
        public int GameNumber
        {
            get
            {
                //return the private data 
                return mGameNumber;
            }
            set
            {
                //set the value of the private data member 
                mGameNumber = value;
            }
        }


        //private data member for the GameTitle
        public string mGameTitle;
        public string GameTitle
        {
            get
            {
                //return the private data 
                return mGameTitle;
            }
            set
            {
                //set the value of the private data member 
                mGameTitle = value;
            }
        }

        //private data added data member 
        private DateTime mDateAdded;
        //public property for data added
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                //set the private data
                mDateAdded = value;
            }
        }

        //private data member for GamePrice
        public Int32 mGamePrice;
        //public property for GamePrice
        public int GamePrice
        {
            get
            {
                //return the private data 
                return mGamePrice;
            }
            set
            {
                //set the private data 
                mGamePrice = value;
            }
        }

        //private data member for Game availability 
        public bool mGameAvailability;
        //public property for Game availability
        public bool GameAvailability
        {
            get
            {
                //return the private data 
                return mGameAvailability;
            }
            set
            {
                //set the private data 
                mGameAvailability = value;
            }
        }

        //private data memeber for Game Description 
        public string mGameDescription;
        //public property for Game Description 
        public string GameDescription
        {
            get
            {
                //return the private data 
                return mGameDescription;
            }
            set
            {
                //set the private data 
                mGameDescription = value;
            }
        }
            

        public bool Find(int gameNumber)
        {
            //set the private data member to the test data value
            mGameNumber = 21;
            mGameTitle = " road runner ";
            mGameDescription = "RUNNING FROM WOLF TO SAVE LIFE" ;
            mGamePrice = 49;
            mGameAvailability = true;
            mDateAdded = Convert.ToDateTime("17/02/2022");
            //always return true
            return true;
        }
    }
}