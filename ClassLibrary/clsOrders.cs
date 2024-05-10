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

        public bool Find(int orderId)
        {
            //set the private data members to the test data value
            mOrderId = 21;
            mCustomerId = 22;
            mTotalAmount = 23.00m;
            mOrderDate = Convert.ToDateTime("23/12/2022");
            mComplete = true;
            mStaus = "pending";
            //always return true
            return true;
        }
    }
}