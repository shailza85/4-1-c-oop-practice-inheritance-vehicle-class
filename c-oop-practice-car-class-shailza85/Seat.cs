using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    public class Seat
    {
        public bool Occupied { get; set; }
        public Seat()
        {
            Occupied = false;
        }
        public Seat(bool occupied)
        {
            Occupied = occupied;
        }
    }
}