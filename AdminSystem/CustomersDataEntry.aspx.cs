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

    protected void txtSubscription_TextChanged(object sender, EventArgs e)
    {

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
            //Capture the customers name
            AnCustomer.Name = Name;
            //capture the DateAdded
            AnCustomer.DateAdded = Convert.ToDateTime(DateAdded);
            //store the address
            AnCustomer.Address = Address;
            //store the country
            AnCustomer.Country = Country;
            //capture the email
            AnCustomer.Email = Email;
            //store the address in the section object
            Session["AnCustomer"] = AnCustomer;
            //navigate to the view page
            Response.Redirect("CustomersViewer.aspx");
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