using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UsersDataEntry : System.Web.UI.Page
{
    //variable to store the primary key  with page level scope
    String UserName;
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsUsers
        clsOrdersUser AUser = new clsOrdersUser();
        //capture the UserName
        string UserName = txtUserName.Text;
        //capture the Password
        string Password = txtPassword.Text;

        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AUser.Valid(UserName, Password);
        if (Error == "")
        {
            //capture the UserName
            AUser.UserName = UserName;
            //capture the Password
            AUser.Password = Password;

            //create a new instance of the orders collection
            clsOrdersUsersCollection UsersList = new clsOrdersUsersCollection();

            //update record
            
            //find the record to update
            UsersList.ThisUser.Find(UserName);
            //set the ThisOrder property
            UsersList.ThisUser = AUser;
            //update the new record
            UsersList.ChangePW();
            
            //redirect to the login page
            Response.Redirect("OrdersLogin.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the login page
        Response.Redirect("OrdersLogin.aspx");
    }
}