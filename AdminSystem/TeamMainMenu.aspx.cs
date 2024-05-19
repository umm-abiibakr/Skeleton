using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAircrafts_Click(object sender, EventArgs e)
    {
        //redirect the user to the aircrafts login page
        //un comment the comment below when you have created your login page
        //Response.Redirect("AircraftsLogin.aspx");
    }

    protected void btnCustomers_Click(object sender, EventArgs e)
    {
        //redirect the user to the customers login page
        //un comment the comment below when you have created your login page
        //Response.Redirect("CustomersLogin.aspx");
    }

    protected void btnManufacturers_Click(object sender, EventArgs e)
    {
        //redirect the user to the manufacturers login page
        //un comment the comment below when you have created your login page
        //Response.Redirect("ManufacturersLogin.aspx");
    }

    protected void btnOrderItems_Click(object sender, EventArgs e)
    {
        //redirect the user to the order items login page
        //un comment the comment below when you have created your login page
        //Response.Redirect("OrderItemsLogin.aspx");
    }

    protected void btnOrders_Click(object sender, EventArgs e)
    {
        //redirect the user to the orders login page
        Response.Redirect("OrdersLogin.aspx");
    }
}