using System;

namespace ClassLibrary
{
    public class clsOrdersUser
    {
        //private data member for the user id property
        private Int32 mUserID;
        //private data member for the username property
        private string mUserName;
        //private data member for the password property
        private string mPassword;
        //private data member for the department property
        private string mDepartment;
        public int UserID
        {
            get
            {
                //return the private data
                return mUserID;
            }
            set
            {
                //set the private data 
                mUserID = value;
            }
        }
        public string UserName
        {
            get
            {
                //return the private data
                return mUserName;
            }
            set
            {
                //set the private data 
                mUserName = value;
            }
        }
        public string Password
        {
            get
            {
                //return the private data
                return mPassword;
            }
            set
            {
                //set the private data 
                mPassword = value;
            }
        }
        public string Department
        {
            get
            {
                //return the private data
                return mDepartment;
            }
            set
            {
                //set the private data 
                mDepartment = value;
            }
        }

        public void Add(clsOrdersUser testItem)
        {
            throw new NotImplementedException();
        }

        public bool FindUser(string UserName, string Password)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the user's userName and password to search for
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);
            //execute the stored procedure 
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            //if one record is found (there should be either one or none)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm everything worked ok
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Find(int UserID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the user's userName and password to search for
            DB.AddParameter("@UserID", UserID);
            //execute the stored procedure 
            DB.Execute("sproc_tblUsers_FindUserID");
            //if one record is found (there should be either one or none)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm everything worked ok
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string userName, string password, string department)
        {

            //create a string variable to store the error
            String Error = "";

            //if the username is blank
            if (userName.Length == 0)
            {
                //record the error
                Error = Error + "The username may not be blank : ";
            }
            //if the username is greater than 20
            if (userName.Length > 20)
            {
                //record the error
                Error = Error + "The username must not be more than 20 : ";
            }

            //if the password is blank
            if (password.Length == 0)
            {
                //record the error
                Error = Error + "The password may not be blank : ";
            }
            //if the password is greater than 30
            if (password.Length > 30)
            {
                //record the error
                Error = Error + "The password must not be more than 30 : ";
            }

            //if the department is blank
            if (department.Length == 0)
            {
                //record the error
                Error = Error + "The department may not be blank : ";
            }
            //if the username is greater than 50
            if (department.Length > 50)
            {
                //record the error
                Error = Error + "The department must not be more than 50 : ";
            }
            //return the error message
            return Error;
        }
    }

}