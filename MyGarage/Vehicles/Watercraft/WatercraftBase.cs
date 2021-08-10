using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    abstract class WatercraftBase : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("You drive 30 nautical miles.");
        }

        public override void Brake()
        {
            Console.WriteLine("You pull down on the throttle and apply the brakes to prepare to turn.");
        }

    }
}
