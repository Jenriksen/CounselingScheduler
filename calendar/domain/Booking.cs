using System.Collections.Generic;
using calendar.User;
using System;

namespace calendar.Booking
{
    public class Booking 
    {

        public int Id { get; set; }
        public User user { get; set; }
        // TODO: Figure out why User isn't working.

        public DateTime BookingStartDateTime { get; set; }
        public DateTime BookingEndDateTime { get; set; }
    }
}