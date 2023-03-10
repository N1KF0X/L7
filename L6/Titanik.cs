using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6
{
    internal class Titanik:Ship
    {
        protected string mark;
        public Titanik(int speed, int loadСapacity, int travelRange, string mark) : base(speed, loadСapacity, travelRange)
        {
            this.mark = mark;
        }

        public void Info()
        {
            Console.WriteLine(mark + "\nГрузоподьёмность: " + LoadСapacity
                + "\nДальность растояние: " + TravelRange + "\n");
        }
    }
}
