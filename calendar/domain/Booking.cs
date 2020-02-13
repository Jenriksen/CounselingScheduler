using System.Collections.Generic;
using System;

namespace domain
{
    public class Booking 
    {

        public int Id { get; set; }
        public User user { get; set; }

        public DateTime BookingStartDateTime { get; set; }
        public DateTime BookingEndDateTime { get; set; }
    }
}