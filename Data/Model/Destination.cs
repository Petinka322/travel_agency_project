using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Data.Model
{
    public class Destination
    {
        public int Id { get; set; }
        public string country { get; set; }
        public string townName { get; set; }
        public string hotelName { get; set; }
        public decimal price { get; set; }
        public int stars { get; set; }
        public string amenities { get; set; }
        public decimal priceOfAmenities { get; set; }
    
}
}
