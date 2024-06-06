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
        // Create a new instance of clsAircrafts
        clsAircrafts AnAircraft = new clsAircrafts();

        // Capture the Aircraft ID
        string AircraftId = txtAircraftId.Text;
        // Capture the Aircraft Name
        string AircraftName = txtAircraftName.Text;
        // Capture the Manufactured Date
        string ManufacturedDate = txtManufacturedDate.Text;
        // Capture the Image URL
        string ImageUrl = txtImageUrl.Text;
        // Capture the Price
        string Price = txtPrice.Text;
        // Capture the Quantity
        string Quantity = txtQuantity.Text;
        // Capture the Description
        string Description = txtDescription.Text;
        // Capture the Availability
        string Availability = chkAvailability.Text;

        // Variable to store any error messages
        string Error = "";
        // Validate the data
        Error = AnAircraft.Valid(AircraftName, ManufacturedDate, ImageUrl, Price, Quantity, Description);

        if (Error == "")
        {
            // Capture the Aircraft ID
            AnAircraft.AircraftId = Convert.ToInt32(AircraftId);
            // Capture the Aircraft Name
            AnAircraft.AircraftName = AircraftName;
            // Capture the Manufactured Date
            AnAircraft.ManufacturedDated = Convert.ToDateTime(ManufacturedDate);
            // Capture the Image URL
            AnAircraft.ImageUrl = ImageUrl;
            // Capture the Price
            AnAircraft.Price = Convert.ToDecimal(Price);
            // Capture the Quantity
            AnAircraft.Quantity = Convert.ToInt32(Quantity);
            // Capture the Description
            AnAircraft.Description = Description;
            // Capture the Availability
            AnAircraft.Availability = chkAvailability.Checked;

            // Create a new instance of the aircraft collection
            clsAircrafts AircraftList = new clsAircrafts();
            // Add the new aircraft record
            Response.Redirect("AircraftsViewer.aspx");
        }
        else
        {
            // Display the error message
            lblError.Text = Error;
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

            void DisplayAircrafts()
            {
                clsAircraftsCollection Aircrafts = new clsAircraftsCollection();
                Aircrafts.ThisAircraft.Find(AircraftId);
                txtAircraftId.Text = Aircrafts.ThisAircraft.AircraftId.ToString();
                txtAircraftName.Text = Aircrafts.ThisAircraft.AircraftName.ToString();
                txtDescription.Text = Aircrafts.ThisAircraft.Description.ToString();
                txtImageUrl.Text = Aircrafts.ThisAircraft.ImageUrl.ToString();
                txtPrice.Text = Aircrafts.ThisAircraft.Price.ToString();
                txtQuantity.Text = Aircrafts.ThisAircraft.Quantity.ToString();
                txtManufacturedDate.Text = Aircrafts.ThisAircraft.ManufacturedDated.ToString();
                chkAvailability.Checked = Aircrafts.ThisAircraft.Availability;
            }

        }
    }
}