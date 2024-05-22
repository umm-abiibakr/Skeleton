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

    protected void btnCancel_Click(object sender, EventArgs e)
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
        AnCustomer.Name = txtName.Text;
        //capture the Date Of Birth
        AnCustomer.DateAdded = Convert.ToDateTime(DateTime.Now);
        //capture the subscription
        AnCustomer.Subscription = chkSubscription.Checked;
        //store the address
        AnCustomer.Address = txtAddress.Text;
        //store the country
        AnCustomer.Country = txtCountry.Text;
        //capture the email
        AnCustomer.Email = Convert.ToString(txtEmail.Text);
        //store the address in the section object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the view page
        Response.Redirect("CustomersViewer.aspx");
    
    }

    protected void txtEmail_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click1(object sender, EventArgs e)
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
        if (Found == true) ;
        {
            //display the values of the properties in the form
            txtName.Text = AnCustomer.Name;
            txtEmail.Text = AnCustomer.Email;
            txtAddress.Text = AnCustomer.Address;
            txtCountry.Text = AnCustomer.Country;
            txtDateOfBirth.Text = AnCustomer.DateAdded.ToString();
            chkSubscription.Checked = AnCustomer.Subscription;


        }

    }

    protected void btnCancel_Click1(object sender, EventArgs e)
    {

    }
}