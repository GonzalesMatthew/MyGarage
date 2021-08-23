using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage.Vehicles.Aircraft
{
    class Boeing747 : IAircraftBase
    {
        public int FuelCapacity { get; set; }
        public string FuelUnits { get; set; }
        public string Color { get; set; }
        public string PaxOccupancy { get; set; }

        public void TakeOff()
        {
            Console.WriteLine("You inform your passengers you are ready for take-off. Strap in.");
        }
    }
}
