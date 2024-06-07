using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrdersUsersCollection
    {
        //private data member for the list
        List<clsOrdersUser> mUsersList = new List<clsOrdersUser>();
        //private member data for thisOrder
        clsOrdersUser mThisUser = new clsOrdersUser();
        //public property for the adddress list
        public List<clsOrdersUser> UsersList
        {
            get
            {
                //return the private data
                return mUsersList;
            }

            set
            {
                //set the private data 
                mUsersList = value;
            }
        }

        public clsOrdersUser ThisUser
        {
            get
            {
                //return the private data
                return mThisUser;
            }

            set
            {
                //set the private data
                mThisUser = value;
            }
        }

        public void ChangePW()
        {
            //update an existing record based on the values of mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@UserID", mThisUser.UserID);
            DB.AddParameter("@UserName", mThisUser.UserName);
            DB.AddParameter("@Password", mThisUser.Password);
            DB.AddParameter("@Department", mThisUser.Department);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblUsers_ForgotPW");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameteers for the stored procedure
            DB.AddParameter("@UserID", mThisUser.UserID);
            //execute the stored procedure
            DB.Execute("sproc_tblUsers_Delete");
        }
    }

    }