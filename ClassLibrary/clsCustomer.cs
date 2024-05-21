using System;
using System.Diagnostics.SymbolStore;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the address id property
        private Int32 mCustomerId;
        //CustomerId public property
        public Int32 CustomerId
        {
            get
            {
                //this line of code sends data out of property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }

        }

        //private data member for the data added property
        private DateTime mDateOfBirth;
        //dataAdded public property
        public DateTime DateOfBirth
        {
            get
            {
                //this line of code sends data out of property
                return mDateOfBirth;
            }
            set
            {
                //this line of code allows data into the property
                mDateOfBirth = value;
            }
        }

        //private data member for the Name property
        private string mName;
        //name public property
        public string Name
        {
            get
            {
                //this line of code sends data out of property
                return mName;
            }
            set
            {
                //this line of code allows data into the property
                mName = value;
            }
        }

        //private data member for the Email property
        private string mEmail;
        //Email public property
        public string Email
        {
            get
            {
                //this line of code sends data out of property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }


        //private data member for the Address property
        private string mAddress;
        //Address public property
        public string Address
        {
            get
            {
                //this line of code sends data out of property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }


        //private data member for the Country property
        private string mCountry;
        //Country public property
        public string Country
        {
            get
            {
                //this line of code sends data out of property
                return mCountry;
            }
            set
            {
                //this line of code allows data into the property
                mCountry = value;
            }
        }


        //private data member for the subscription property
        private Boolean mSubscription;
        //subscription public property
        public bool Subscription
        {
            get
            {
                //this line of code sends data out of property
                return mSubscription;
            }
            set
            {
                //this line of code allows data into the property
                mSubscription = value;
            }
        }



        public DateTime DateOfbirth;

        public bool Find(int CustomerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Customer Id to search for
            DB.AddParameter("@CustomerId", CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members

                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mCountry = Convert.ToString(DB.DataTable.Rows[0]["Country"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfbirth"]);
                mSubscription = Convert.ToBoolean(DB.DataTable.Rows[0]["Subscription"]);
                //return that everything worked Ok
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicatingthere is a problem 
                return false;

            }
        }
    }
}
