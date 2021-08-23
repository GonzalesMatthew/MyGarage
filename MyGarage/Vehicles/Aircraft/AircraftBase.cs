using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    abstract class AircraftBase : IVehicle, IAircraftBase
    {
        public int Capacity { get; set; }
        public string CapacityUnits { get; set; }
        public string Color { get; set; }
        public string PaxOccupancy { get; set; }
        public string PowerType { get; set; }

        public void Brake() { }

        public void Drive() { }
        public void Refuel() { }

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
