using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    private int morderItems_id;
    private string mquantity;
    private string mprice;
    private DateTime mdispatchDate;
    private bool morderReceived;
    private object orderItems_id;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the data connection

        clsDataConnection DB = new clsDataConnection();

        //add the parameter for the OrderItems_id to search for

        DB.AddParameter("@orderItems_id", orderItems_id);

        //execute the stored procedure

        DB.Execute("sproc_tblOrderItems_FilterByOrderItems_id");

        //if one record is found (there should be either one or zero)

        if (DB.Count == 1)

        {

            //copy the data from the database to the private data members

            morderItems_id = Convert.ToInt32(DB.DataTable.Rows[0]["OrderItems_id"]);

            mquantity = Convert.ToString(DB.DataTable.Rows[0]["Quantity"]);

            mprice = Convert.ToString(DB.DataTable.Rows[0]["Price"]);

            mdispatchDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DispatchDate"]);

            morderReceived = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderReceived"]);

            //return that everything worked OK

            return true;

        }

        //if no record was found

        else

        {

            //return false indicating there is a problem

            return false;

        }
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {

       
        {
            //create a new instance of clsOrderItems
            clsorderitems AnOrderItem = new clsorderitems();

            //capture the OrderItems_id
            int OrderItems_id = Convert.ToInt32(txtOrderItems_id.Text);

            //capture the Quantity
            string Quantity = txtQuantity.Text;

            //capture the Price
            string Price = txtPrice.Text;

            //capture the DispatchDate
            DateTime DispatchDate = Convert.ToDateTime(txtDispatchDate.Text);

            //capture the OrderReceived
            bool OrderReceived = chkOrderReceived.Checked;

            //variable to store any error messages
            string Error = "";

            //validate the data
            Error = AnOrderItem.Valid(OrderItems_id, Quantity, Price, DispatchDate, OrderReceived);

            if (Error == "")
            {
                //capture the OrderItems_id
                AnOrderItem.orderItems_id = OrderItems_id;

                //capture the Quantity
                AnOrderItem.Quantity = Quantity;

                //capture the Price
                AnOrderItem.Price = Price;

                //capture the DispatchDate
                AnOrderItem.dispatchDate = DispatchDate;

                //capture the OrderReceived
                AnOrderItem.orderReceived = OrderReceived;

                //store the order item in the session object
                Session["AnOrderItem"] = AnOrderItem;

                //navigate to the view page
                Response.Redirect("OrderItemsViewer.aspx");
            }
            else
            {
                //display the error message
                lblError.Text = Error;
            }
        }
    }
}