using System;

namespace YourGarage
{
    interface IAircraftBase : IVehicle
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