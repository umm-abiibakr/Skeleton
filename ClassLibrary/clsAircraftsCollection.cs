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
    }

    //constructor for the class
    public clsAircraftsCollection()
    {
        //create the items of test data
        clsAircrafts TestItem = new clsAircrafts();
        //set its properties
        TestItem.Availability = true;
        TestItem.AircraftId = 1;
        TestItem.AircraftName = "Boeing 747";
        TestItem.ManufacturedDated = DateTime.Now;
        TestItem.Price = 100000000.00m;
        TestItem.Description = "Large passenger aircraft";
        TestItem.Quantity = 10;
        TestItem.ImageUrl = "http://example.com/boeing747.jpg";
        //add the test item to the test list
        mAircraftList.Add(TestItem);
        //reinitialize the object for some new data
        TestItem = new clsAircrafts();
        //set its properties
        TestItem.Availability = true;
        TestItem.AircraftId = 2;
        TestItem.AircraftName = "Airbus A380";
        TestItem.ManufacturedDated = DateTime.Now;
        TestItem.Price = 120000000.00m;
        TestItem.Description = "Double-deck, wide-body, four-engine jet airliner";
        TestItem.Quantity = 8;
        TestItem.ImageUrl = "http://example.com/airbusa380.jpg";
        //add the item to the test list
        mAircraftList.Add(TestItem);
    }

    public clsAircraftsCollection()
    {
        Int32 Index = 0;
        Int32 RecordCount = 0;
        clsDataConnection DB = new clsDataConnection();
        DB.Execute("sproc_tblAircrafts_SelectAll");
        RecordCount = DB.Count;
        while (Index < RecordCount)
        {
            clsAircrafts AnAircraft = new clsAircrafts();
            AnAircraft.Availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
            AnAircraft.AircraftId = Convert.ToInt32(DB.DataTable.Rows[Index]["AircraftId"]);
            AnAircraft.AircraftName = Convert.ToString(DB.DataTable.Rows[Index]["AircraftName"]);
            AnAircraft.ManufacturedDated = Convert.ToDateTime(DB.DataTable.Rows[Index]["ManufacturedDated"]);
            AnAircraft.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
            AnAircraft.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
            AnAircraft.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
            AnAircraft.ImageUrl = Convert.ToString(DB.DataTable.Rows[Index]["ImageUrl"]);

            object mAircraftList = null;
            mAircraftList.Add(AnAircraft);
            Index++

        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisAircraft
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@AircraftName", mThisAircraft.AircraftName);
            DB.AddParameter("@ManufacturedDated", mThisAircraft.ManufacturedDated);
            DB.AddParameter("@Price", mThisAircraft.Price);
            DB.AddParameter("@Description", mThisAircraft.Description);
            DB.AddParameter("@Quantity", mThisAircraft.Quantity);
            DB.AddParameter("@ImageUrl", mThisAircraft.ImageUrl);
            DB.AddParameter("@Availability", mThisAircraft.Availability);

            //execute the query returning the primary key value
            return DB.Execute("sproc_Aircrafts_Insert");
        }


    }

    internal class mThisAircraft
    {
    }
}