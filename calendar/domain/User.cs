using System;
using System.Collections.Generic;
using calendar.Calendar;
using calendar.Hold;

namespace calendar.User
{
    public class User
    {
        public string FirstName { get; set; }
        public string LasteName { get; set; }
        public List<Hold> AssociatedHold { get; set; }
        // TODO: Figure out why Hold isn't working.
    }
}