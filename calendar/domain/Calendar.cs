using System;
using System.Collections.Generic;
using calendar.Timeslot;

namespace calendar.Calendar
{
    public class Calendar
    {
        public string Name { get; set; }
        public List<TimeSlot> Timeslots { get; set; }
        // TODO: Figure out why Timeslot isn't working
    }

    
}
