using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsAircraftsCollection
    {
        //private data member for the list
        List<clsAircrafts> mAircraftsList = new List<clsAircrafts>();
        //private member data for thisOrder
        clsAircrafts mThisAircraft = new clsAircrafts();
        //public property for the adddress list
        public List<clsAircrafts> AircraftsList
        {
            get
            {
                //return the private data
                return mAircraftsList;
            }

            set
            {
                //set the private data 
                mAircraftsList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the private data
                return mAircraftsList.Count;
            }

            set
            {
                //deal with this later 
            }
        }
        public clsAircrafts ThisAircraft
        {
            get
            {
                //return the private data
                return mThisAircraft;
            }

            set
            {
                //set the private data
                mThisAircraft = value;
            }
        }

        public int Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AircraftId", mThisAircraft.AircraftId);
            DB.Execute("sproc_Aircrafts_Delete");
        }

        public void ReportByAircraftName(string v)
        {

        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    //constructor for the class

    void PopulateArray(clsDataConnection DB)
    {
        // Populates the array list based on the data table in the parameter DB
        // Variable for the index
        Int32 Index = 0;
        // Variable to store the record count 
        Int32 RecordCount;
        // Get the count of the records 
        RecordCount = DB.Count;
        // Clear the private array list
        mAircraftsList = new List<clsAircrafts>();
        // While there are records to process
        while (Index < RecordCount)
        {
            // Create a blank aircraft object
            clsAircrafts AnAircraft = new clsAircrafts();
            // Read in the fields for the current record
            AnAircraft.Availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
            AnAircraft.AircraftId = Convert.ToInt32(DB.DataTable.Rows[Index]["AircraftId"]);
            AnAircraft.AircraftName = Convert.ToString(DB.DataTable.Rows[Index]["AircraftName"]);
            AnAircraft.ManufacturedDated = Convert.ToDateTime(DB.DataTable.Rows[Index]["ManufacturedDated"]);
            AnAircraft.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
            AnAircraft.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
            AnAircraft.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
            AnAircraft.ImageUrl = Convert.ToString(DB.DataTable.Rows[Index]["ImageUrl"]);
            // Add the record to the private data member
            mAircraftsList.Add(AnAircraft);
            // Point at the next record 
            Index++;
        }
    }


    public clsAircraftsCollection()
    {
        // Object for the data connection
        clsDataConnection DB = new clsDataConnection();
        // Execute the stored procedure to select all aircrafts
        DB.Execute("sproc_tblAircrafts_SelectAll");
        // Populate the array list with the data table
        PopulateArray(DB);
    }

    public int Add()
    {
        // Adds a record to the database based on the values of ThisAircraft
        // Connect to the database
        clsDataConnection DB = new clsDataConnection();
        // Set the parameters for the stored procedure
        DB.AddParameter("@AircraftName", mThisAircraft.AircraftName);
        DB.AddParameter("@ManufacturedDate", mThisAircraft.ManufacturedDate);
        DB.AddParameter("@Price", mThisAircraft.Price);
        DB.AddParameter("@Availability", mThisAircraft.Availability);
        DB.AddParameter("@Quantity", mThisAircraft.Quantity);
        DB.AddParameter("@Description", mThisAircraft.Description);
        DB.AddParameter("@ImageUrl", mThisAircraft.ImageUrl);
        // Execute the query returning the primary key value
        return DB.Execute("sproc_tblAircrafts_Insert");
    }

    public void Update()
    {
        // Update an existing record based on the values of ThisAircraft
        // Connect to the database
        clsDataConnection DB = new clsDataConnection();
        // Set the parameters for the stored procedure
        DB.AddParameter("@AircraftId", mThisAircraft.AircraftId);
        DB.AddParameter("@AircraftName", mThisAircraft.AircraftName);
        DB.AddParameter("@ManufacturedDate", mThisAircraft.ManufacturedDate);
        DB.AddParameter("@Price", mThisAircraft.Price);
        DB.AddParameter("@Availability", mThisAircraft.Availability);
        DB.AddParameter("@Quantity", mThisAircraft.Quantity);
        DB.AddParameter("@Description", mThisAircraft.Description);
        DB.AddParameter("@ImageUrl", mThisAircraft.ImageUrl);
        // Execute the query returning the primary key value
        DB.Execute("sproc_tblAircrafts_Update");
    }

    public void Delete()
    {
        // Deletes the record pointed to by ThisAircraft
        // Connect to the database
        clsDataConnection DB = new clsDataConnection();
        // Set the parameter for the stored procedure
        DB.AddParameter("@AircraftId", mThisAircraft.AircraftId);
        // Execute the stored procedure
        DB.Execute("sproc_tblAircrafts_Delete");
    }

    public void ReportByStatus(string Status)
    {
        // Filters the records based on the provided status
        // Connect to the database
        clsDataConnection DB = new clsDataConnection();
        // Send the Status parameter to the database
        DB.AddParameter("@Status", Status);
        // Execute the stored procedure
        DB.Execute("sproc_tblAircrafts_FilterByStatus");
        // Populate the array list with the data table
        PopulateArray(DB);
    }
}