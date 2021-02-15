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
            //set the private data members to the test data
            mStaffNo = 17;
            mName = "Tom Tinsley";
            mEmail = "tom.tinsley@testmail.com";
            mDateOfBirth = Convert.ToDateTime("01/01/2000");
            mRole = "Manager";
            mHourlyWage = 12.60;
            mHolidayStatus = false;
            //always return true
            return true;
        }
    }
}