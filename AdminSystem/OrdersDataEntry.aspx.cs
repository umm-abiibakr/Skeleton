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
        //create a new instance of clsOrders
        clsOrders AnOrder = new clsOrders();
        //capture the Order ID
        AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        //capture the Customer ID
        AnOrder.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //capture the order date
        AnOrder.OrderDate = Convert.ToDateTime(DateTime.Now); 
        //capture the Total Amount
        AnOrder.TotalAmount = Convert.ToDecimal(txtCustomerId.Text);
        //capture the status of the order
        AnOrder.Status = txtStatus.Text;
        //capture complete check box
        AnOrder.Complete = chkComplete.Checked;
        //store in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the view page
        Response.Redirect("OrdersViewer.aspx");
    }



    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the order class
        clsOrders AnOrder = new clsOrders();
        //create a variable to store the primary key
        Int32 OrderId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user 
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //find the record
        Found = AnOrder.Find(OrderId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerId.Text = AnOrder.CustomerId.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtStatus.Text = AnOrder.Status.ToString();
            txtTotalAmount.Text = AnOrder.TotalAmount.ToString();
            chkComplete.Checked = AnOrder.Complete;
        }

    }
}