using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsAircrafts
        clsAircrafts AnAircraft = new clsAircrafts();
        //get the data from the session object
        AnAircraft = (clsAircrafts)Session["AnAircraft"];
        //display for entry
        Response.Write(AnAircraft.AircraftId);
        Response.Write(AnAircraft.AircraftName);
        Response.Write(AnAircraft.Quantity);
        Response.Write(AnAircraft.ManufacturedDated);
        Response.Write(AnAircraft.Description);
        Response.Write(AnAircraft.ImageUrl);
        Response.Write(AnAircraft.Price);
        Response.Write(AnAircraft.Availability);
    }
}
