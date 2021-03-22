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
            //capture the customer name
            ACustomer.CustomerName = CustomerName;
            //capture the email
            ACustomer.CustomerEmail = CustomerEmail;
            //capture the customer address
            ACustomer.CustomerAddress = CustomerAddress;
            //capture the date added
            ACustomer.DateAdded = Convert.ToDateTime(DateAdded);
            //store the customer in the session object
            Session["ACustomer"] = ACustomer;
            //redirect to the viewer page
            Response.Write("CustomerViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void txtCustomerID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtCustomerName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click1(object sender, EventArgs e)
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
        }
    }
}