using System;
using System.Diagnostics.SymbolStore;
using System.Security.Cryptography.X509Certificates;

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
        private DateTime mDateAdded;
        //dataAdded public property
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
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
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
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

        public string Valid(string name, string email, string address, string country, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the Name is blank
            if(name.Length == 0)
            {
                //record the error
                Error = Error + "The name may not be blank : ";
            }
            //if the name is greater than 50 characters
            if (name.Length > 50)
            {
                //record the error
                Error = Error + "The name must be less than 50 characters : ";
            }

            //if the Email is blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The email may not be blank : ";
            }
            //if the name is greater than 50 characters
            if (email.Length > 50)
            {
                //record the error
                Error = Error + "The email must be less than 50 characters : ";
            }

            //if the Address is blank
            if (address.Length == 0)
            {
                //record the error
                Error = Error + "The address may not be blank : ";
            }
            //if the address is greater than 50 characters
            if (address.Length > 50)
            {
                //record the error
                Error = Error + "The address must be less than 50 characters : ";
            }

            //if the Country is blank
            if (country.Length == 0)
            {
                //record the error
                Error = Error + "The country may not be blank : ";
            }
            //if the country is greater than 50 characters
            if (country.Length > 50)
            {
                //record the error
                Error = Error + "The country must be less than 50 characters : ";
            }

            //create an instance of DateTime to compare with DateTemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;

            try
            {

                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);

                //check to see if the date is less than today's date
                if (DateTemp < DateComp) //compare dateAdded with Date
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is gretaer than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }

            }
            catch
            {
                //record ther error
                Error = Error + "The date was not a valid date : ";
            }
            //return any eror messages
            return Error;
        }
    }
}
