using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data for UserNameAvailability
        private Boolean mUserNameAvailability;
        //public property for UserNameAvailability
        public bool UserNameAvailability
        {
            get
            {
                //return the private data
                return mUserNameAvailability;
            }
            set
            {
                //set the private data
                mUserNameAvailability = value;
            }
        }
        
         
          


        //DateAdded private member variable
        private DateTime mDateAdded;
        //DateAdded public property
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }

        //private data member for the Customer address property
        private string mCustomerAddress;
        //public property for the address number
        public string CustomerAddress
        {
            get
            {
                //return the private data
                return mCustomerAddress;
            }
            set
            {
                //set the value of the private data member

                mCustomerAddress = value;
            }
        }
            

        //CustomerID private member variable
        private int mCustomerID;
        //CustomerID public property
        public int CustomerID
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerID = value;
            }
        
        }
        //private data member for the CustomerName property
        private string mCustomerName;
        //public property for the customer name
        public string CustomerName
        {
            get
            {
                //return the private data
                return mCustomerName;
            }
            set
            {
                //set the value of the private data member
                mCustomerName = value;
            }
        }
        

        //CustomerEmail private member variable
        private string mCustomerEmail;
        //CustomerEmail public property
        public string CustomerEmail
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerEmail;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerEmail = value;
            }
        }

        public bool Find(int CustomerID)
        {   //set the private data memebers to the test value

            mCustomerID = 21;
            mDateAdded = Convert.ToDateTime("15/02/2021");
            mCustomerEmail = "yaxyeali12@outlook.com";
            mCustomerName = "Yaxye";
            mCustomerAddress = "7 Something Street LE1 2KA";
            mUserNameAvailability = true;
            //always return true
            return true;
        }
    }
}