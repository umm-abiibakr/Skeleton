using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key  with page level scope
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be processed
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderId != -1)
            {
                //display the current data for the record
                DisplayOrder();
            }
        }
    }

    void DisplayOrder()
    {
        //create an instance of the address book
        clsOrdersCollection Orders = new clsOrdersCollection();
        //find the record to update
        Orders.ThisOrder.Find(OrderId);
        //display the data for the record
        txtOrderId.Text = Orders.ThisOrder.OrderId.ToString();
        txtStatus.Text = Orders.ThisOrder.Status.ToString();
        txtTotalAmount.Text = Orders.ThisOrder.TotalAmount.ToString();
        txtOrderDate.Text = Orders.ThisOrder.OrderDate.ToString();
        chkComplete.Checked = Orders.ThisOrder.Complete; 
        txtCustomerId.Text = Orders.ThisOrder.CustomerId.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrders
        clsOrders AnOrder = new clsOrders();
        //capture the Customer ID
        string CustomerId = txtCustomerId.Text;
        //capture the order date
        string OrderDate = txtOrderDate.Text; 
        //capture the Total Amount
        string TotalAmount = txtTotalAmount.Text;
        //capture the status of the order
        string Status = txtStatus.Text;
        //capture complete check box
        string Complete = chkComplete.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(Status, OrderDate);
        if (Error == "")
        {
            //capture the order id
            AnOrder.OrderId = OrderId;
            //capture the status of the order
            AnOrder.Status = Status;
            //capture the order date
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            //capture the total amount 
            AnOrder.TotalAmount = Convert.ToDecimal(TotalAmount);
            //capture the customer id 
            AnOrder.CustomerId = Convert.ToInt32(CustomerId);
            //capture complete 
            AnOrder.Complete = chkComplete.Checked;

            //create a new instance of the orders collection
            clsOrdersCollection OrdersList = new clsOrdersCollection();

            //if this is a new record i.e OrderId = -1 then add the data
            if (OrderId == -1)
            {
            //set the ThisOrder property
            OrdersList.ThisOrder = AnOrder;
            //add the new record
            OrdersList.Add();
            }
            //otherwise it must be an pdate
            else
            {
                //find the record to update
                OrdersList.ThisOrder.Find(OrderId);
                //set the ThisOrder property
                OrdersList.ThisOrder = AnOrder;
                //update the new record
                OrdersList.Update();
            }
            //redirect to the list page
            Response.Redirect("OrdersList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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