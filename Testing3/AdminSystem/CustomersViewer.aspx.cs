﻿using System;
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
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //display for entry
        Response.Write(AnCustomer.Name);
        Response.Write(AnCustomer.DateAdded);
        Response.Write(AnCustomer.Email);
        Response.Write(AnCustomer.Subscription);
        Response.Write(AnCustomer.Address);
        Response.Write(AnCustomer.Country);
    }
}