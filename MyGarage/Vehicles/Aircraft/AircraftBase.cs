using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    abstract class AircraftBase : Vehicle
    {
        public virtual void Fly()
        {
            Console.WriteLine("You fly 100 km.");
        }
        public virtual void Land()
        {
            Console.WriteLine("You land, but realize your brakes are fading.");
        }
    }
}
