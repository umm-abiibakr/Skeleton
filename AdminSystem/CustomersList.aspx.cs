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
        //get the number of the address to be processed
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            //if this is teh not a new record
            if (CustomerId != -1)
            {
                //display the current data for the record
                DisplayCustomers();
            }
        }
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
        lstCustomerList.DataTextField = "Address";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
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
        if(lstCustomerList.SelectedIndex != -1)
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

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 CustomerId;
        //if a record has been selected from the list
        if(lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the rcord delete
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerId"] = CustomerId;
            //redirect to the edit page
            Response.Redirect("CustomersConfirmDelete.aspx");
        }
        else //if no record has be selected
        {
            //display the error message
            lblError.Text = "Please select a record from the list to delete";
        }

    }
}