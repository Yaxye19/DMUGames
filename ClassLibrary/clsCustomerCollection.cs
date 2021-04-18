using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member for the this customer
        clsCustomer mThisCustomer = new clsCustomer();

        //constructor for the class
        public clsCustomerCollection()
        {

            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //worry about this later
            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@UsernameAvailability", mThisCustomer.UsernameAvailability);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@UsernameAvailability", mThisCustomer.UsernameAvailability);
        }

        public void Delete()
        {   //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByCustomerEmail(string CustomerEmail)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@CustomerEmail", CustomerEmail);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerEmail");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the fileds from the current record
                ACustomer.UsernameAvailability = Convert.ToBoolean(DB.DataTable.Rows[Index]["UsernameAvailability"]);
                ACustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                ACustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                ACustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }
    }
}