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
        //create a new instance of clsOrderItems
        clsorderitems  AnOrderItem = new clsorderitems();
        //get the data from the session object
        AnOrderItem = (clsorderitems)Session["AnOrderItem"];
        //display the order id for this entry
        Response.Write("OrderItems ID: " + AnOrderItem.orderItems_id + "\n");
        Response.Write("Quantity: " + AnOrderItem.Quantity + "\n");
        Response.Write("Price: " + AnOrderItem.Price + "\n");
        Response.Write("Dispatch Date: " + AnOrderItem.dispatchDate + "\n");
        Response.Write("Order Received: " + AnOrderItem.orderReceived + "\n");
    }
}