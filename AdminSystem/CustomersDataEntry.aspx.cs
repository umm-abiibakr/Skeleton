using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{

    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {//get the number of the address to be processed
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            //if this is teh not a new record
            if (CustomerId != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }

    }

    protected void txtSubscription_TextChanged(object sender, EventArgs e)
    {

    }

     void DisplayCustomer()
    {
        //create a instance of the customer class
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update
        CustomerBook.ThisCustomer.Find(CustomerId);
        //display the data for the record
        txtCustomerId.Text = CustomerBook.ThisCustomer.CustomerId.ToString();
        txtName.Text = CustomerBook.ThisCustomer.Name.ToString();
        txtEmail.Text = CustomerBook.ThisCustomer.Email.ToString();
        txtAddress.Text = CustomerBook.ThisCustomer.Address.ToString();
        txtCountry.Text = CustomerBook.ThisCustomer.Country.ToString();
        txtDateAdded.Text = CustomerBook.ThisCustomer.DateAdded.ToString();
        chkSubscription.Checked = CustomerBook.ThisCustomer.Subscription;

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        
        //create a new instance of clsCustomer();
        clsCustomer AnCustomer = new clsCustomer();
        
        //Capture the customers name
        string Name = txtName.Text;
        //capture the DateAdded
        string DateAdded = txtDateAdded.Text;
        //capture the subscription
        string Subscription = chkSubscription.Text;
        //store the address
        string Address = txtAddress.Text;
        //store the country
        string Country = txtCountry.Text;
        //capture the email
        string Email = txtEmail.Text;
        //variable to store any error messgaes
        string Error = "";
        //validate the data
        Error = AnCustomer.Valid(Name, Email, Address, Country, DateAdded);
        if (Error == "")
        {
            //capture the customer id
            AnCustomer.CustomerId = CustomerId; 
            //Capture the customers name
            AnCustomer.Name = Name;
            //capture the email
            AnCustomer.Email = Email;
            //store the address
            AnCustomer.Address = Address;
            //store the country
            AnCustomer.Country = Country;
            //capture the DateAdded
            AnCustomer.DateAdded = Convert.ToDateTime(DateAdded);
            //capture subscription
            AnCustomer.Subscription = chkSubscription.Checked;
            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            
            //if this is a new record i.e. CustomerId = -1 then add the data
            if (CustomerId == -1)
            {
                //set teh This Customer property
                CustomerList.ThisCustomer = AnCustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerId);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //update the record
                CustomerList.Update();

            }
            
            //redirect back to list page
            Response.Redirect("CustomersList.aspx");
        }
        else
        {
            //display tehr error message
            lblError.Text = Error;

        }
    
    }

    protected void txtEmail_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtName_TextChanged(object sender, EventArgs e)
    {

    }

    

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create a instance of the customer class
        clsCustomer AnCustomer = new clsCustomer();
        //create a variable to store the primary key
        Int32 CustomerId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //find the record
        Found = AnCustomer.Find(CustomerId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtName.Text = AnCustomer.Name;
            txtEmail.Text = AnCustomer.Email;
            txtAddress.Text = AnCustomer.Address;
            txtCountry.Text = AnCustomer.Country;
            txtDateAdded.Text = AnCustomer.DateAdded.ToString();
            chkSubscription.Checked = AnCustomer.Subscription;
            lblError.Text = "";
        }
        else
        {
            lblError.Text = "CustomerId not found";
        }

    }

    protected void btnCancel_Click1(object sender, EventArgs e)
    {

    }


}