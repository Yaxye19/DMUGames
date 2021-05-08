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
        //create a new instance of clsAddress
        clsStock GameStock = new clsStock();
        //get the data from the session object 
        GameStock = (clsStock)Session["GameStock"];
        //display the game number on page
        Response.Write(GameStock.GameNumber);

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsAddress
        clsStock GameStock = new clsStock();
        //capture the game number 
        GameStock.GameNumber = Convert.ToInt32(txtGameNumber.Text);
        //store the address in the session  object
        Session["GameStock"] =GameStock;
        //navigate to the viewer page 
        Response.Redirect("AddressBookViewer.aspx");
    }

    protected void txtGameAvailability_TextChanged(object sender, EventArgs e)
    {
        
    }
}