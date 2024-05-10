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
        //create a new instance of clsOrders
        clsOrders AnOrder = new clsOrders();
        //get the data from the session object
        AnOrder = (clsOrders)Session["AnOrder"];
        //display the order id for this entry
        Response.Write("Order ID: " + AnOrder.OrderId + "\n");
        Response.Write("Customer ID: " + AnOrder.CustomerId + "\n");
        Response.Write("Order Date: " + AnOrder.OrderDate + "\n");
        Response.Write("Status: " + AnOrder.Status + "\n") ;
        Response.Write("Total Amount: " + AnOrder.TotalAmount + "\n");
        Response.Write("Complete: " + AnOrder.Complete + "\n");

    } 
}