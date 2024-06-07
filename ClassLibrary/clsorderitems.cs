using System;

namespace ClassLibrary
{
    public class clsorderitems
    {
        public string Quantity;
        public int orderItems_id;
        public DateTime dispatchDate;
        public string price;
        public bool orderReceived;

        public string Price { get; set; }
        public bool Found { get; set; }

        public void Find(int quantity, string price, DateTime dispatchDate, bool orderReceived)
        {
            throw new NotImplementedException();
        }

        public bool Find(bool orderReceived)
        {
            throw new NotImplementedException();
        }

        public bool Find(object dispatchDate)
        {
            throw new NotImplementedException();
        }

        public bool Find(object price)
        {
            throw new NotImplementedException();
        }

        public string Valid(int orderItems_id, string quantity, string price, DateTime dispatchDate, bool orderReceived)
        {
            throw new NotImplementedException();
        }

        public class clsOrderItems
        {
            private Int32 mOrderItems_id;
            private string mQuantity;
            private string mPrice;
            private DateTime mDispatchDate;
            private Boolean mOrderReceived;

            public int orderItems_id
            {
                get
                {
                    return mOrderItems_id;
                }
                set
                {
                    mOrderItems_id = value;
                }
            }

            public string Quantity
            {
                get
                {
                    return mQuantity;
                }
                set
                {
                    mQuantity = value;
                }
            }

            public string Price
            {
                get
                {
                    return mPrice;
                }
                set
                {
                    mPrice = value;
                }
            }

            public DateTime DispatchDate
            {
                get
                {
                    return mDispatchDate;
                }
                set
                {
                    mDispatchDate = value;
                }
            }

            public Boolean OrderReceived
            {
                get
                {
                    return mOrderReceived;
                }
                set
                {
                    mOrderReceived = value;
                }
            }

            public bool Find(int orderItems_Id)
            {
                //create an instance of the data connection

                clsDataConnection DB = new clsDataConnection();

                //add the parameter for the OrderItems_id to search for

                DB.AddParameter("@orderItems_id", orderItems_id);

                //execute the stored procedure

                DB.Execute("sproc_tblOrderItems_FilterByOrderItems_id");

                //if one record is found (there should be either one or zero)

                if (DB.Count == 1)

                {

                    //copy the data from the database to the private data members

                    mOrderItems_id = Convert.ToInt32(DB.DataTable.Rows[0]["OrderItems_id"]);

                    mQuantity = Convert.ToString(DB.DataTable.Rows[0]["Quantity"]);

                    mPrice = Convert.ToString(DB.DataTable.Rows[0]["Price"]);

                    mDispatchDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DispatchDate"]);

                    mOrderReceived = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderReceived"]);

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
            public string Valid(int OrderItems_id, string Quantity, string Price, DateTime DispatchDate, bool OrderReceived)
            {
                //create a string variable to store the error
                String Error = "";

                //if the OrderItems_id is less than 1
                if (OrderItems_id < 1)
                {
                    //record the error
                    Error = Error + "The Order Items ID must be at least 1 : ";
                }

                //if the Quantity is blank
                if (Quantity.Length == 0)
                {
                    //record the error
                    Error = Error + "The Quantity may not be blank : ";
                }

                //if the Quantity is not a valid number
                int QuantityTemp;
                if (!int.TryParse(Quantity, out QuantityTemp))
                {
                    //record the error
                    Error = Error + "The Quantity must be a valid number : ";
                }

                //if the Price is blank
                if (Price.Length == 0)
                {
                    //record the error
                    Error = Error + "The Price may not be blank : ";
                }

                //if the Price is not a valid decimal
                decimal PriceTemp;
                if (!decimal.TryParse(Price, out PriceTemp))
                {
                    //record the error
                    Error = Error + "The Price must be a valid decimal : ";
                }

                //if the DispatchDate is in the past
                if (DispatchDate < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The Dispatch Date cannot be in the past : ";
                }

                //if the OrderReceived is not a valid boolean
                if (!(OrderReceived == true || OrderReceived == false))
                {
                    //record the error
                    Error = Error + "The Order Received must be a valid boolean : ";
                }

                //return any error messages
                return Error;
            }
        }
    }
}