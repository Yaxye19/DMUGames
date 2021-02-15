using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff StaffMember = new clsStaff();
        //get the data from the session object
        StaffMember = (clsStaff) Session["StaffMember"];
        //display the name for this entry
        Response.Write(StaffMember.Name);
        //display the email for this entry
        Response.Write(StaffMember.Email);
        //display the date of birth for this entry
        Response.Write(StaffMember.DateOfBirth);
        //display the role for this entry
        Response.Write(StaffMember.Role);
        //display the hourly wage for this entry
        Response.Write(StaffMember.HourlyWage);
        //display the holiday status for this entry
        Response.Write(StaffMember.HolidayStatus);
    }
}