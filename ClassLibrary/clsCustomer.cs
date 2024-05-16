using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public string Email;
        public DateTime DateOfbirth;

        public bool Subscription { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
    }
}