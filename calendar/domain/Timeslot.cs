using System;
using System.Collections.Generic;

namespace calendar.Timeslot
{
    public class Timeslot
    {
        public DateTime SlotStartDateTime { get; set; }
        public DateTime SlotEndDateTime { get; set; }
        public List<Booking> Bookings { get; set; }
        // TODO: Figure out why Booking isn't working
    }    
}