using System;
using System.Collections.Generic;

namespace domain
{
    public class Timeslot
    {
        public DateTime SlotStartDateTime { get; set; }
        public DateTime SlotEndDateTime { get; set; }
        public List<Booking> Bookings { get; set; }
    }    
}