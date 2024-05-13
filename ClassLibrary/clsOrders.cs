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
            if (DB.Count ==1 )
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
    }
}