using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create new instance of clsManufacturers
        clsManufacturers AManufacturer = new clsManufacturers();
        //capture the Manufacturer name
        AManufacturer.Name = txtName.Text;
        //store the Manufacturer in the session object
        Session["AManufacturer"] = AManufacturer;
        //Navigate to the view page
        Response.Redirect("ManufacturersViewer.aspx");
    }
}