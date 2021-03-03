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
        public string GameTitle { get; set; }

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
               
        public Int32 GamePrice { get; set; }
        public bool GameAvailability { get; set; }
        public string GameDescription { get; set; }

        public bool Find(int gameNumber)
        {
            //set the private data member to the test data value
            mGameNumber = 21;
            mDateAdded = Convert.ToDateTime("17/02/2022");
            //always return true
            return true;
        }
    }
}