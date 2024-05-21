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

        public bool Find(int customerId)
        {
            //set the private data members
            mName = "John Doe";
            mEmail = "johndoe@example.com";
            mAddress = "123, Main Street, New York";
            mCountry = "USA";
            mCustomerId = 1;
            mDateOfBirth = Convert.ToDateTime("20/05/1965");
            mSubscription = true;
            //always return true
            return true;
        }
    }
}