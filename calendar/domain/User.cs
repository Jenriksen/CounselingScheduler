using System;
using System.Collections.Generic;

namespace domain
{
    public class User
    {
        public string FirstName { get; set; }
        public string LasteName { get; set; }
        public List<Hold> AssociatedHold { get; set; }
    }
}