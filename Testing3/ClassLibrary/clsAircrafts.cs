using System;

namespace ClassLibrary
{
    public class clsAircrafts
    {
        //private data member for the aircraft id
        private Int32 mAircraftId;
        public Int32 AircraftId
        {
            get
            {
                //this line of code sends data out
                return mAircraftId;
            }
            set
            {
                //this line of code allows data in
                mAircraftId = value;
            }
        }
        //private data member for the aircraft id
        private decimal mPrice;
        public decimal Price
        {
            get
            {
                //this line of code sends data out
                return mPrice;
            }
            set
            {
                //this line of code allows data in
                mPrice = value;
            }
        }
        //private data member for the aircraft id
        private string mDescription;
        public string Description
        {
            get
            {
                //this line of code sends data out
                return mDescription;
            }
            set
            {
                //this line of code allows data in
                mDescription = value;
            }
        }
        //private data member for the aircraft id
        private string mImageUrl;
        public string ImageUrl
        {
            get
            {
                //this line of code sends data out
                return mImageUrl;
            }
            set
            {
                //this line of code allows data in
                mImageUrl = value;
            }
        }
        //private data member for the aircraft id
        private Int32 mQuantity;
        public Int32 Quantity
        {
            get
            {
                //this line of code sends data out
                return mQuantity;
            }
            set
            {
                //this line of code allows data in
                mQuantity = value;
            }
        }
        //private data member for the aircraft id
        private Boolean mAvailability;
        public bool Availability
        {
            get
            {
                //this line of code sends data out
                return mAvailability;
            }
            set
            {
                //this line of code allows data in
                mAvailability = value;
            }
        }
        //private data member for the aircraft id
        private DateTime mManufacturedDate;
        public DateTime ManufacturedDated
        {
            get
            {
                //this line of code sends data out
                return mManufacturedDate;
            }
            set
            {
                //this line of code allows data in
                mManufacturedDate = value;
            }
        }
        //private data member for the aircraft id
        private string mAircraftName;
        public string AircraftName
        {
            get
            {
                //this line of code sends data out
                return mAircraftName;
            }
            set
            {
                //this line of code allows data in
                mAircraftName = value;
            }
        }


        public bool Find(int AircraftId)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for 
            DB.AddParameter("@AircraftId", AircraftId);
            //execute the stored procedure
            DB.Execute("sproc_tblAircrafts_FilterByAircraftId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mAircraftId = Convert.ToInt32(DB.DataTable.Rows[0]["AircraftsId"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["This is a test description."]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalAmount"]);
                mManufacturedDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ManufacturedDate"]);
                mAircraftName = Convert.ToString(DB.DataTable.Rows[0]["Boeing 737"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Complete"]);
                mImageUrl = Convert.ToString(DB.DataTable.Rows[0]["This is a test description."]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["AircraftsId"]);
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
    }
}