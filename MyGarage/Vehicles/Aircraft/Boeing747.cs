using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage.Vehicles.Aircraft
{
    class Boeing747 : AircraftBase
    {
        public void TakeOff()
        {
            Console.WriteLine("You inform your passengers you are ready for take-off. Strap in.");
        }
    }
}
