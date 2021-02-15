using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff StaffMember = new clsStaff();
        //capture the name
        StaffMember.Name = txtName.Text;
        //capture the email
        StaffMember.Email = txtEmail.Text;
        //capture the date of birth
        StaffMember.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
        //capture the role
        StaffMember.Role = txtRole.Text;
        //capture the houly wage
        StaffMember.HourlyWage = Convert.ToDouble(txtHourlyWage.Text);
        //capture the holiday status
        StaffMember.HolidayStatus = chkHolidayStatus.Checked;
        //store the name in the session object
        Session["StaffMember"] = StaffMember;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff StaffMember = new clsStaff();
        //variable to store the primary key
        Int32 StaffNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffNo = Convert.ToInt32(txtStaffNo.Text);
        //find the record
        Found = StaffMember.Find(StaffNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtName.Text = StaffMember.Name;
            txtEmail.Text = StaffMember.Email;
            txtDateOfBirth.Text = StaffMember.DateOfBirth.ToString();
            txtRole.Text = StaffMember.Role;
            txtHourlyWage.Text = StaffMember.HourlyWage.ToString();
            chkHolidayStatus.Checked = StaffMember.HolidayStatus;
        }
    }
}