﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //this function handdles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaffMembers();
        }
    }

    void DisplayStaffMembers()
    {
        //create an instance of the staff collection
        clsStaffCollection StaffMembers = new clsStaffCollection();
        //set the data source to the list of staff in the collection
        lstStaffList.DataSource = StaffMembers.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffNo";
        //set the data firl to display
        lstStaffList.DataTextField = "Name";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 StaffNo;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffNo = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffNo"] = StaffNo;
            //redirect to the edit page
            Response.Redirect("StaffDelete.aspx");
        }
        else
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 StaffNo;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffNo = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffNo"] = StaffNo;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the staff collection
        clsStaffCollection StaffMembers = new clsStaffCollection();
        StaffMembers.ReportByName(txtFilter.Text);
        lstStaffList.DataSource = StaffMembers.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffNo";
        //set the name of the field to the display
        lstStaffList.DataTextField = "Name";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the staff collection
        clsStaffCollection StaffMembers = new clsStaffCollection();
        StaffMembers.ReportByName("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstStaffList.DataSource = StaffMembers.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffNo";
        //set the name of the field to display
        lstStaffList.DataTextField = "Name";
        //bind the data to the list
        lstStaffList.DataBind();
    }
}