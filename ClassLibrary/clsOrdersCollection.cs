using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        //private data member for the list
        List<clsOrders> mOrdersList = new List<clsOrders>();
        //private member data for thisOrder
        clsOrders mThisOrder = new clsOrders();
        //public property for the adddress list
        public List<clsOrders> OrdersList
        {
            get
            {
                //return the private data
                return mOrdersList;
            }

            set
            {
                //set the private data 
                mOrdersList = value;
            }
        }
        public int Count {
            get
            {
                //return the private data
                return mOrdersList.Count;
            }

            set
            {
                //deal with this later loool 
            }
        }
        public clsOrders ThisOrder 
        {
            get
            {
                //return the private data
                return mThisOrder;
            }

            set
            {
                //set the private data
                mThisOrder = value;
            }
        }

        //constructor for the class
        void PopulateArray (clsDataConnection DB)
        {
                //populates the array list based on the data table in the parameter DB
                //variable for the index
                Int32 Index = 0;
                //variable to store the record count 
                Int32 RecordCount;
                //get the count of the records 
                RecordCount = DB.Count;
                //clear the private array list
                mOrdersList = new List<clsOrders>();
                //while there are records to process
                while (Index < RecordCount)
                {
                    //create a blank order object
                    clsOrders AnOrder = new clsOrders();
                    //read in the fields for the current record
                    AnOrder.Complete = Convert.ToBoolean(DB.DataTable.Rows[Index]["Complete"]);
                    AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                    AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                    AnOrder.TotalAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);
                    AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                    AnOrder.Status = Convert.ToString(DB.DataTable.Rows[Index]["Status"]);
                    //add the record to the private data member
                    mOrdersList.Add(AnOrder);
                    //point at the next record 
                    Index++;
                }
            }
        public clsOrdersCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblOrders_SelectAll");
            //populate the array list with the data table
            PopulateArray (DB);
           
        }

        public int Add()
        {
            //adds a record to the database based on the values  of mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Status", mThisOrder.Status);
            DB.AddParameter("@TotalAmount", mThisOrder.TotalAmount);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Complete", mThisOrder.Complete);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrders_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@Status", mThisOrder.Status);
            DB.AddParameter("@TotalAmount", mThisOrder.TotalAmount);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Complete", mThisOrder.Complete);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblOrders_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameteers for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_Delete");
        }

        public void ReportByStatus(string Status)
        {
            //filters the records based on delivered, cancelled or processing order
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Status parameter to the database
            DB.AddParameter("@Status", Status);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByStatus");
            //populate the array list with the data table
            PopulateArray(DB);

        }
        }
}