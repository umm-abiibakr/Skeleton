using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack == false)

            DisplayAircrafts();

    }

    void DisplayAircrafts()
    {
        clsAircraftsCollection Aircrafts = new clsAircraftsCollection();
        lstAircraftsList.DataSource = Aircrafts.AircraftsList;
        lstAircraftsList.DataValueField = "AircraftId";
        lstAircraftsList.DataTextField = "AircraftName";
        lstAircraftsList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["AircraftId"] = -1;
        Response.Redirect("AddressBookEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 AircraftId;
        if (lstAircraftsList.SelectedIndex != -1)
        {
            AircraftId = Convert.ToInt32(lstAircraftsList.SelectedValue);
            Session["AircraftId"] = AircraftId;
            Response.Redirect("AircraftsDataEntry.aspx");

        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 AircraftId;
        if (lstAircraftsList.SelectedIndex != -1)
        {
            AircraftId = Convert.ToInt32(lstAircraftsList.SelectedValue);
            Session["AircraftId"] = AircraftId;
            Response.Redirect("AircraftConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Please select a record from the list to delete ";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsAircraftsCollection AnAircraft = new clsAircraftsCollection();
        AnAircraft.ReportByAircraftName(txtFilter.Text);
        lstAircraftsList.DataSource = AnAircraft.AircraftsList;
        lstAircraftsList.DataValueField = "Aircraft Id";
        lstAircraftsList.DataTextField = "Aircraft Name";
        lstAircraftsList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsAircraftsCollection AnAircraft = new clsAircraftsCollection();
        AnAircraft.ReportByAircraftName("");
        lstAircraftsList.DataSource = AnAircraft.AircraftsList;
        lstAircraftsList.DataValueField = "Aircraft Id";
        lstAircraftsList.DataTextField = "Aircraft Name";
        lstAircraftsList.DataBind();
    }
}