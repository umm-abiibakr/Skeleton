using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public bool Complete { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string Status { get; set; }
        public decimal TotalAmount { get; set; }
    }
}