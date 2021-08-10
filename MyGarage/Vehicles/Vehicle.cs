using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    abstract class Vehicle
    {
        public string PowerType { get; set; }
        public int Capacity { get; set; }
        public string CapacityUnits { get; set; }
        public string Color { get; set; }
        public string PaxOccupancy { get; set; }

        public virtual void Refuel()
        {
            Console.WriteLine("You refuel to max capacity.");
        }
        public virtual void Drive()
        {
            Console.WriteLine("You drive 10 km.");
        }
        public virtual void Brake()
        {
            Console.WriteLine("You brake, but realize they are fading.");
        }
    }
}
