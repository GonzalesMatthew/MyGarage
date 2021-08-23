using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage.Vehicles.Aircraft
{
    class JetFighter : IAircraftBase
    {
        public void Jettison()
        {
            Console.WriteLine("You engage emergency maneuvers and then jettison from your aircraft.");
        }

        public override void Fly()
        {
            Console.WriteLine("You trust your instincts and do a barrel roll.");
        }
    }
}
