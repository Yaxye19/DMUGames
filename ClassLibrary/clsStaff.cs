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

        public string Valid(string name, string email, string dateOfBirth, string role, string hourlyWage)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store data values
            Double WageTemp;

            //if name is blank
            if (name.Length == 0)
            {
                //record the error
                Error = Error + "The name can not be blank : ";
            }
            //if the name is greater than 50 characters
            if (name.Length > 50)
            {
                //record the error
                Error = Error + "The maxmimum name length is 50 : ";
            }

            //if email is blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The email can not be blank : ";
            }
            //if email is greater than 50 characters
            if (email.Length > 50)
            {
                //record the error
                Error = Error + "The maximum email length is 50 : ";
            }

            //if role is blank
            if (role.Length == 0)
            {
                //record the error
                Error = Error + "The role can not be blank : ";
            }
            //if role is greater than 50 characters
            if (role.Length > 50)
            {
                //record the error
                Error = Error + "The maximum role length is 50 : ";
            }

            //copy the hourlyWage value to the WageTemp variable
            WageTemp = Convert.ToDouble(hourlyWage);
            //if wage is less than zero
            if (WageTemp < 0.00)
            {
                //record the error
                Error = Error + "The hourly wage can not be a negative number : ";
            }
            //if they are earning more than 3 digits an hour
            if (WageTemp >= 1000.00)
            {
                Error = Error + "The maximum hourly wage is 999.99";
            }

            //return any error messages
            return Error;
        }
    }
}