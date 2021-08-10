using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage.Vehicles.Watercraft
{
    class JetSki : WatercraftBase
    {
        public void Speed()
        {
            Console.WriteLine("You roll the throttle all the way back as you enter the deep zone and start speeding on the lake.");
        }

        public override void Drive()
        {
            Console.WriteLine("You drive your jetski to the lake and hit a ramp! Woohoo!");
        }
    }
}
