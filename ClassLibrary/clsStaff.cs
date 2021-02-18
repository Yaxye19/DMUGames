using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //staffNo private member variable
        private Int32 mStaffNo;
        //StaffNo public property
        public Int32 StaffNo
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffNo;
            }
            set
            {
                //this line of code allows data into the property
                mStaffNo = value;
            }
        }

        //name private member variable
        private string mName;
        //Name public property
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        //email private member variable
        private string mEmail;
        //Email public property
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        //dateOfBirth private member variable
        private DateTime mDateOfBirth;
        //DateOfBirth public property
        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }

        //role private member variabe
        private string mRole;
        //Role public property
        public string Role
        {
            get
            {
                return mRole;
            }
            set
            {
                mRole = value;
            }
        }

        //hourlyWage private member variabe
        private double mHourlyWage;
        //HourlyWage public property
        public double HourlyWage
        {
            get
            {
                return mHourlyWage;
            }
            set
            {
                mHourlyWage = value;
            }
        }

        //holidayStatus private member variabe
        private bool mHolidayStatus;
        //HolidayStatus public property
        public bool HolidayStatus
        {
            get
            {
                return mHolidayStatus;
            }
            set
            {
                mHolidayStatus = value;
            }
        }

        public bool Find(int StaffNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the new staff no to search for
            DB.AddParameter("@StaffNo", StaffNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffNo");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mRole = Convert.ToString(DB.DataTable.Rows[0]["Role"]);
                mHourlyWage = Convert.ToDouble(DB.DataTable.Rows[0]["HourlyWage"]);
                mHolidayStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["HolidayStatus"]);
                //return that everthing worked okay
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