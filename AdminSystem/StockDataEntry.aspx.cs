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
        clsStock Gamestock = new clsStock();
        //get the data from the session object 
        Gamestock = (clsStock)Session["AnAddress"];
        //display the game number on page
        Response.Write(Gamestock.GameNumber);

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //creat a new instance of clsAddress
        clsStock GameStock = new clsStock();
        //capture the game number 
        GameStock.GameNumber = txtGameNo.Text;
        //store the address in the session  object
        Session["GameStock"] =GameStock;
        //navigate to the viewer page 
        Response.Redirect("AddressBookViewer.aspx");
    }
}