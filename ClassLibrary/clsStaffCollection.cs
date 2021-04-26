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
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        //public property for the staff list
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

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffNo", mThisStaffMember.StaffNo);
            DB.AddParameter("@Name", mThisStaffMember.Name);
            DB.AddParameter("@Email", mThisStaffMember.Email);
            DB.AddParameter("@DateOfBirth", mThisStaffMember.DateOfBirth);
            DB.AddParameter("@Role", mThisStaffMember.Role);
            DB.AddParameter("@HourlyWage", mThisStaffMember.HourlyWage);
            DB.AddParameter("@HolidayStatus", mThisStaffMember.HolidayStatus);
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            //deletes the record pointed by thisStaffMember
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffNo", mThisStaffMember.StaffNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByName(string Name)
        {
            //filters the records based on a full or partial name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Name parameter to the database
            DB.AddParameter("@Name", Name);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of the records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while(Index < RecordCount)
            {
                //create a blank staff member
                clsStaff StaffMember = new clsStaff();
                //read in the fields from the current record
                StaffMember.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                StaffMember.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                StaffMember.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                StaffMember.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                StaffMember.Role = Convert.ToString(DB.DataTable.Rows[Index]["Role"]);
                StaffMember.HourlyWage = Convert.ToDouble(DB.DataTable.Rows[Index]["HourlyWage"]);
                StaffMember.HolidayStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["HolidayStatus"]);
                //add the record to the private data member
                mStaffList.Add(StaffMember);
                //point at the next record
                Index++;
            }
        }
    }
}