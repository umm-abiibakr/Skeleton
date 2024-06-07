using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 AircraftId;
    protected void Page_Load(object sender, EventArgs e)
    {
        AircraftId = Convert.ToInt32(Session["AircraftId"]);

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsAircraftsCollection Aircrafts = new clsAircraftsCollection();
        Aircrafts.ThisAircraft.Find(AircraftId);
        Aircrafts.Delete();
        Response.Redirect("AircraftsList.aspx");
    }


    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("AircraftsList.aspx");
    }
}