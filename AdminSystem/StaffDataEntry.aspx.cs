using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StaffNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffNo != -1)
            {
                //display the current data for the record
                DisplayStaffMember();
            }
        }
    }

    void DisplayStaffMember()
    {
        //create an instance of the staff list
        clsStaffCollection StaffList = new clsStaffCollection();
        //find the record to update
        StaffList.ThisStaffMember.Find(StaffNo);
        //display the data for this record
        txtStaffNo.Text = StaffList.ThisStaffMember.StaffNo.ToString();
        txtName.Text = StaffList.ThisStaffMember.Name;
        txtEmail.Text = StaffList.ThisStaffMember.Email;
        txtDateOfBirth.Text = StaffList.ThisStaffMember.DateOfBirth.ToString();
        txtRole.Text = StaffList.ThisStaffMember.Role;
        txtHourlyWage.Text = StaffList.ThisStaffMember.HourlyWage.ToString();
        chkHolidayStatus.Checked = StaffList.ThisStaffMember.HolidayStatus;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff StaffMember = new clsStaff();
        //capture the name
        string Name = txtName.Text;
        //capture the email
        string Email = txtEmail.Text;
        //capture the date of birth
        string DateOfBirth = txtDateOfBirth.Text;
        //capture the role
        string Role = txtRole.Text;
        //capture the houly wage
        string HourlyWage = txtHourlyWage.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = StaffMember.Valid(Name, Email, DateOfBirth, Role, HourlyWage);
        if(Error == "")
        {
            //capture the staff no
            StaffMember.StaffNo = StaffNo;
            //capture the name
            StaffMember.Name = Name;
            //capture the email
            StaffMember.Email = Email;
            //capture the date of birth
            StaffMember.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            //capture the role
            StaffMember.Role = Role;
            //capture the hourly wage
            StaffMember.HourlyWage = Convert.ToDouble(HourlyWage);
            //capture the holiday status
            StaffMember.HolidayStatus = chkHolidayStatus.Checked;
            //create a new instance of the staff collection
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new record then add the data
            if (StaffNo == -1)
            {
                //set the ThisStaffMember property
                StaffList.ThisStaffMember = StaffMember;
                //add the new record
                StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StaffList.ThisStaffMember.Find(StaffNo);
                //set the ThisStaffMember property
                StaffList.ThisStaffMember = StaffMember;
                //update the record
                StaffList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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