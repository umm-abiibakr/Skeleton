using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private member data for thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();



        public clsCustomerCollection()
        {

            //onject for the data conncet
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);

        }

        //public property for the Customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }


        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisCustomer
            //coonect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Country", mThisCustomer.Country);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@Subscription", mThisCustomer.Subscription);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");

        }

        public void Update()
        {
            //update an existing record based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Country", mThisCustomer.Country);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@Subscription", mThisCustomer.Subscription);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void ReportByName(string Name)
        {
            //filters the records based on full or partial name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the name parameter to the database
            DB.AddParameter("@Name", Name);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set this private data
                mThisCustomer = value;
            }
        }





        void PopulateArray(clsDataConnection DB)
        {
            //populates teh array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count 
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private arary list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank addresss object 
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields from thecurrent record
                AnCustomer.Subscription = Convert.ToBoolean(DB.DataTable.Rows[Index]["Subscription"]);
                AnCustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnCustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnCustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnCustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnCustomer.Country = Convert.ToString(DB.DataTable.Rows[Index]["Country"]);
                //add the record to the private data ,member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;
            }
        }
    

    }
}



