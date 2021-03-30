using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{   //variable to store the primary key with page level scope
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (CustomerID != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }

    void DisplayCustomer()
    {
        //create an instance of the customer list
        clsCustomerCollection CustomerList = new clsCustomerCollection();
        //find the record to update
        CustomerList.ThisCustomer.Find(CustomerID);
        //display the data for this record
        txtCustomerID.Text = CustomerList.ThisCustomer.CustomerID.ToString();
        txtCustomerName.Text = CustomerList.ThisCustomer.CustomerName;
        txtCustomerEmail.Text = CustomerList.ThisCustomer.CustomerEmail;
        txtCustomerAddress.Text = CustomerList.ThisCustomer.CustomerAddress;
        txtDateAdded.Text = CustomerList.ThisCustomer.DateAdded.ToString();
        chkUserNameAvailability.Checked = CustomerList.ThisCustomer.UsernameAvailability;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {   //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the name 
        string CustomerName = txtCustomerName.Text;
        //capture the email
        string CustomerEmail = txtCustomerEmail.Text;
        //capture the Address
        string CustomerAddress = txtCustomerAddress.Text;
        //capture the date added
        string DateAdded = txtDateAdded.Text;
        //store the customer in the session object
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, DateAdded);
        if(Error == "")
        {
            //capture the customer ID
            ACustomer.CustomerID = CustomerID;
            //capture the customer name
            ACustomer.CustomerName = CustomerName;
            //capture the email
            ACustomer.CustomerEmail = CustomerEmail;
            //capture the customer address
            ACustomer.CustomerAddress = CustomerAddress;
            //capture the date added
            ACustomer.DateAdded = Convert.ToDateTime(DateAdded);
            //capture usernameavailability
            ACustomer.UsernameAvailability = chkUserNameAvailability.Checked;
            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new record then add the data
            if (CustomerID == -1)
            {
                //set the ThisStaffMember property
                CustomerList.ThisCustomer = ACustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerID);
                //set the ThisStaffMember property
                CustomerList.ThisCustomer = ACustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }




    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = ACustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerAddress.Text = ACustomer.CustomerAddress;
            txtCustomerEmail.Text = ACustomer.CustomerEmail;
            txtCustomerName.Text = ACustomer.CustomerName;
            txtDateAdded.Text = ACustomer.DateAdded.ToString();
            chkUserNameAvailability.Checked = ACustomer.UsernameAvailability;
        }
    }

    protected void txtCustomerName_TextChanged(object sender, EventArgs e)
    {

    }
}