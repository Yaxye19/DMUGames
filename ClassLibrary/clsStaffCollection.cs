using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisStaffMember
        clsStaff mThisStaffMember = new clsStaff();

        //constructor for the class
        public clsStaffCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff member
                clsStaff StaffMember = new clsStaff();
                //read in the fields from the current record
                StaffMember.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                StaffMember.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                StaffMember.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                StaffMember.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                StaffMember.Role = Convert.ToString(DB.DataTable.Rows[Index]["Role"]);
                StaffMember.HourlyWage = Convert.ToInt32(DB.DataTable.Rows[Index]["HourlyWage"]);
                StaffMember.HolidayStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["HolidayStatus"]);
                //add the record to the private data member
                mStaffList.Add(StaffMember);
                //point at the next record
                Index++;
            }
        }

        //public property for the address list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //do this later
            }
        }

        //public property for ThisStaffMember
        public clsStaff ThisStaffMember
        {
            get
            {
                //return the private data
                return mThisStaffMember;
            }
            set
            {
                //set the private data
                mThisStaffMember = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisStaffMember
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Name", mThisStaffMember.Name);
            DB.AddParameter("@Email", mThisStaffMember.Email);
            DB.AddParameter("@DateOfBirth", mThisStaffMember.DateOfBirth);
            DB.AddParameter("@Role", mThisStaffMember.Role);
            DB.AddParameter("@HourlyWage", mThisStaffMember.HourlyWage);
            DB.AddParameter("@HolidayStatus", mThisStaffMember.HolidayStatus);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }
    }
}