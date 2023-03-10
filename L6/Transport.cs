using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6
{
    internal abstract class Transport
    {
        public Transport(int speed, int loadСapacity, int travelRange)
        {
            Speed = speed;
            LoadСapacity = loadСapacity;
            TravelRange = travelRange;
        }

        abstract public int Speed { get; set; }
        abstract public int LoadСapacity { get; set; }
        abstract public int TravelRange { get; set; }
    }
}
