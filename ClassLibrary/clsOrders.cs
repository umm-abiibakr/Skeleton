using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        //private data member for the complete property
        private Boolean mComplete;
        public bool Complete {
            get
            {
                //this line of code sends data out of the property
                return mComplete;
            }
            set
            {
                //this line of code allows data into the property
                mComplete = value;
            }
        }

        //private data member for the order date property
        private DateTime mOrderDate;
        public DateTime OrderDate {
            get
            {
                //this line of code sends data out of the property
                return mOrderDate;
            }
            set
            {
                //this line of code allows data into the property
                mOrderDate = value;
            }
        }

        //private data member for the order id property
        private Int32 mOrderId;
        public Int32 OrderId
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //this line of code allows data into the property
                mOrderId = value;
            }
        }

        //private data member for the customer id property
        private Int32 mCustomerId;
        public int CustomerId {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }

        //private data member for the customer id property
        private string mStaus;
        public string Status
        {
            get
            {
                //this line of code sends data out of the property
                return mStaus;
            }
            set
            {
                //this line of code allows data into the property
                mStaus = value;
            }
        }

        //private data member for the customer id property
        private decimal mTotalAmount;
        public decimal TotalAmount {
            get
            {
                //this line of code sends data out of the property
                return mTotalAmount;
            }
            set
            {
                //this line of code allows data into the property
                mTotalAmount = value;
            }
        }

        public bool Find(int OrderId)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for 
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByOrderId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mTotalAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalAmount"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mStaus = Convert.ToString(DB.DataTable.Rows[0]["Status"]);
                mComplete = Convert.ToBoolean(DB.DataTable.Rows[0]["Complete"]);
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

        public string Valid(string status, string orderDate, string totalAmount)
        {
            // create an instance of DateTime to compare with DateTemp
            DateTime DateComp = DateTime.Now;
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            Decimal TotalTemp;
            TotalTemp = Convert.ToDecimal(TotalAmount);
            if (TotalTemp < decimal.MinusOne)
            {
                //record the error
                Error = Error + "The total amount may not be less than 0.00 : ";
            }
            if (TotalTemp > decimal.MaxValue)
            {
                //record the error
                Error = Error + "The total amount may not be less than 0.00 : ";
            }
            //if the Status is blank
            if (status.Length == 0)
            {
                //record the error
                Error = Error + "The status may not be blank : ";
            }
            //if the status is greater than 50
            if (status.Length > 50)
            {
                //record the error
                Error = Error + "The status must be less than 50 : ";
            }

            try
            {
                //copy the orderDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(orderDate);
                //check to see if the data is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
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


        
            //return the error message
            return Error;

        }
    }
}