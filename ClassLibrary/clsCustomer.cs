using System;

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
                //this line of
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }


        public string Email;
        public DateTime DateOfbirth;

        public bool Subscription { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }

        public bool Find(int customerId)
        {
            //set the private data members
            mCustomerId = 1;
            mDateOfBirth = Convert.ToDateTime("20/05/1965");
            //always return true
            return true;
        }
    }
}