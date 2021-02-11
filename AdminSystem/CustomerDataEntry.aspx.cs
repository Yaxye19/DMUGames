﻿using System;
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
        ACustomer.CustomerName = txtCustomerName.Text;
        //store the customer in the session object
        Session["ACustomer"] = ACustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void txtCustomerID_TextChanged(object sender, EventArgs e)
    {

    }
}