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
            //Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for 
            DB.AddParameter("@GameNumber", GameNumber);
            //execute the stored procrdure
            DB.Execute("sproc_tblStock_FiLterByGameNumber");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {

                //copy the data from the database to the private data members
                mGameNumber = Convert.ToInt32(DB.DataTable.Rows[0]["GameNumbwe"]);
                mGameTitle = Convert.ToString(DB.DataTable.Rows[0]["GameDescription"]);
                mGameDescription = Convert.ToString(DB.DataTable.Rows[0]["GameDescription"]);
                mGamePrice = Convert.ToInt32(DB.DataTable.Rows[0]["GamePrice"]);
                mGameAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["GameAvailability"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem 
                return false;
            }
        }
    }
}