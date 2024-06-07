﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsorderItemsUsers
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

    
        public void Add(clsOrderItemsCollection testItem)
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
    }
}
