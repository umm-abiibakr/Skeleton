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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        
        //navigate to the view page
        Response.Redirect("CustomersViewer.aspx");
        //create a new instance of clsCustomer();
        clsCustomer AnCustomer = new clsCustomer();
        //Capture the customers name
        AnCustomer.Name = txtName.Text;
        //capture the Date Of Birth
        AnCustomer.DateOfBirth = Convert.ToDateTime(DateTime.Now);
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



    }

    protected void txtSubscription_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}