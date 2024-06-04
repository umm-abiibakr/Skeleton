using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
                //display the current data for the record
                DisplayCustomers();
        
        }
        //create a new instance of clsCustomerUser
        clsCustomerUser AnUser = new clsCustomerUser();
        //get data from the session object
        AnUser = (clsCustomerUser)Session["AnUser"];
        //display the user name
        Response.Write("Logged in as: " + AnUser.UserName);
    }

    void DisplayCustomers()
    {
        //create an instance of the Customers collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data sourec to list of customers in the collection
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerId";
        //set the data field to display
        lstCustomerList.DataTextField = "Name";
        //bind the data to the list
        lstCustomerList.DataBind();
    }




    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsCustomerCollection AnCustomer = new clsCustomerCollection();
        //retrieve the value of post code from the presentation layer
        AnCustomer.ReportByName(txtFilter.Text);
        //set the data source to the list of customers in the collection
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        //set the name of the primary key 
        lstCustomerList.DataValueField = "CustomerId";
        //set the name of the field to display
        lstCustomerList.DataTextField = "Name";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsCustomerCollection AnCustomer = new clsCustomerCollection();
        //set an empty string
        AnCustomer.ReportByName("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of customers in the collection
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        //set the name of the primary key 
        lstCustomerList.DataValueField = "CustomerId";
        //set the name of the field to display
        lstCustomerList.DataTextField = "Name";
        //bind the data to the list
        lstCustomerList.DataBind();

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerId"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomersDataEntry.aspx");
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 CustomerId;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the rpimary key value of the record to edit
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerId"] = CustomerId;
            //redirect to the edit page
            Response.Redirect("CustomersDataEntry.aspx");
        }
        else //if no record has been seleted
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }
    protected void lstCustomerList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        //redircet to the main page
        Response.Redirect("TeamMainMenu.aspx");
    }



}