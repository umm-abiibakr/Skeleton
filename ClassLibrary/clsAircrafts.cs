using System;

namespace ClassLibrary
{
    public class clsAircrafts
    {
        public int AircraftId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
        public bool Availability { get; set; }
        public DateTime ManufacturedDate { get; set; }
        public string AircraftName { get; set; }
    }
}