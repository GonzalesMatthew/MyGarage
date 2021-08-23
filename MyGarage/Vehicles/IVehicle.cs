using System;

namespace YourGarage
{
    interface IVehicle
    {
        int FuelCapacity { get; set; }
        string FuelUnits { get; set; }
        string Color { get; set; }
        string PaxOccupancy { get; set; }
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