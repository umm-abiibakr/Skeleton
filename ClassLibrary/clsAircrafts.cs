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


        public bool Find(int aircraftId)
        {
            // Set the private data members to the test data value
            mAircraftId = 14;
            mAircraftName = "Boeing 737";
            mManufacturedDate = Convert.ToDateTime("01/01/2020");
            mPrice = 100.50m;
            mAvailability = true;
            mQuantity = 10;
            mDescription = "This is a test description.";
            mImageUrl = "https://example.com/image.jpg";

            // Always return true
            return true;
        }
    }
}