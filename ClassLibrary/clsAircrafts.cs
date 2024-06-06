using System;
using System.Net;
using System.Xml.Linq;

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
        private DateTime mManufacturedDated;
        public DateTime ManufacturedDated
        {
            get
            {
                //this line of code sends data out
                return mManufacturedDated;
            }
            set
            {
                //this line of code allows data in
                mManufacturedDated = value;
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
                mManufacturedDated = Convert.ToDateTime(DB.DataTable.Rows[0]["ManufacturedDate"]);
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

        public string Valid(string aircraftName, string description, string imageUrl, object manufacturedDated, string quantity, string description1)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateComp = DateTime.Now;
            //if the Name is blank
            if (aircraftName.Length == 0)
            {
                //record the error
                Error = Error + "The name may not be blank : ";
            }
            //if the name is greater than 50 characters
            if (aircraftName.Length > 50)
            {
                //record the error
                Error = Error + "The name must be less than 50 characters : ";
            }

            //if the imageurl is blank
            if (imageUrl.Length == 0)
            {
                //record the error
                Error = Error + "The imageUrl may not be blank : ";
            }
            //if the name is greater than 50 characters
            if (imageUrl.Length > 50)
            {
                //record the error
                Error = Error + "The imageUrl must be less than 50 characters : ";
            }

            //if the description is blank
            if (description.Length == 0)
            {
                //record the error
                Error = Error + "The description may not be blank : ";
            }


            //create an instance of DateTime to compare with DateTemp
            //in the if statements

            try
            {
                //copy the orderDate value to the DateTemp variable
                ManufacturedDated = Convert.ToDateTime(ManufacturedDated);
                //check to see if the data is less than today's date
                if (ManufacturedDated < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (ManufacturedDated > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }

            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
        }

        public string Valid(string aircraftName, string description, string imageUrl, string manufacturedDated)
        {
            throw new NotImplementedException();
        }

        public string Valid(string aircraftName, string description, string imageUrl, object manufacturedDated)
        {
            throw new NotImplementedException();
        }
    }
}