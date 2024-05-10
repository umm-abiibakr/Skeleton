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
}