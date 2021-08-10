using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage.Vehicles.Cars
{
    class SurabuBRZ : Car
    {
        public void PedalDance()
        {
            Console.WriteLine("You do the pedal dance and turn off all traction control systems.");
        }

        public override void Drive()
        {
            Console.WriteLine("You go for a drive and feel your supercharger pull you through the turns.");
        }
    }
}
