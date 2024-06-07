using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void btnOK_Click(object sender, EventArgs e)
    {
       
        // Create a new instance of the clsAircrafts
        clsAircrafts AnAircraft = new clsAircrafts();

        // Capture the Aircraft ID
        AnAircraft.AircraftId = Convert.ToInt32(txtAircraftId.Text);

        // Capture the Aircraft Name
        AnAircraft.AircraftName = txtAircraftName.Text;

        // Capture the Manufactured Date
        AnAircraft.ManufacturedDated = Convert.ToDateTime(txtManufacturedDate.Text);

        // Capture the Image URL
        AnAircraft.ImageUrl = (txtImageUrl.Text);

        // Capture the Price
        AnAircraft.Price = Convert.ToDecimal(txtPrice.Text);

        // Capture the Quantity
        AnAircraft.Quantity = Convert.ToInt32(txtQuantity.Text);

        // Store the aircraft in the session object
        Session["AnAircraft"] = AnAircraft;

        // Navigate to the view page
        Response.Redirect("AircraftsViewer.aspx");
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the aircraft class
        clsAircrafts AnAircraft = new clsAircrafts();
        //create a variable to store the primary key 
        Int32 AircraftId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user 
        AircraftId = Convert.ToInt32(txtAircraftId.Text);
        //find the record
        Found = AnAircraft.Find(AircraftId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in form
            txtAircraftId.Text = AnAircraft.AircraftId.ToString();
            txtAircraftName.Text = AnAircraft.AircraftName;
            txtDescription.Text = AnAircraft.Description;
            txtImageUrl.Text = AnAircraft.ImageUrl;
            txtPrice.Text = AnAircraft.Price.ToString();
            txtQuantity.Text = AnAircraft.Quantity.ToString();
            txtManufacturedDate.Text = AnAircraft.ManufacturedDated.ToString();
            chkAvailability.Checked = AnAircraft.Availability;


        }
    }
}