using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6
{
    internal abstract class Auto: Transport
    {

        protected Auto(int speed, int loadСapacity, int travelRange) : base(speed, loadСapacity, travelRange)
        {
        }

        public override int Speed { get; set;}

        public override int LoadСapacity { get; set; }

        public override int TravelRange { get; set; }
    }
}
