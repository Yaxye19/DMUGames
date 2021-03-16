using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data for UserNameAvailability
        private Boolean mUsernameAvailability;
        //public property for UserNameAvailability
        public bool UsernameAvailability
        {
            get
            {
                //return the private data
                return mUsernameAvailability;
            }
            set
            {
                //set the private data
                mUsernameAvailability = value;
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
        private Int32 mCustomerID;
        //CustomerID public property
        public Int32 CustomerID
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
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Customer ID number to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be euther one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                UsernameAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["UserNameAvailability"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                //return that everything worked
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string customerName, string customerEmail, string customerAddress, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the CustomerName is blank
            if(customerName.Length == 0)
            {
                //record the error
                Error = Error + "The customer name may not be blank : ";
            }
            //if the customer name is greater than 50 characters
            if(customerName.Length > 50)
            {
                //record the error
                Error = Error + "The customer name must be less than 50 characters : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past ;";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future: ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date: ";
            }
            //is the customer email blank
            if(customerEmail.Length == 0)
            {
                //record the error
                Error = Error + "The customer email may not be blank : ";
            }
            //if the customer email is too long 
            if(customerEmail.Length > 50)
            {
                //record the error
                Error = Error + "The customer email must be less than 50 characters; ";
            }
            //is the customerAddress blank
            if(customerAddress.Length == 0)
            {
                //record the error
                Error = Error + "The Customer Address may not be blank : ";
            }
            //if the customer address is too long
            if(customerAddress.Length > 50)
            {
                //record the error 
                Error = Error + "The customer address must be less than 50 characters : ";
            }
            //return any error messages
            return Error;
        }
    }
}