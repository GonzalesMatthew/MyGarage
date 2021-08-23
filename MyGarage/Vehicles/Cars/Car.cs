using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    abstract class Car : IVehicle, ICar
    {
        public int FuelCapacity { get; set; }
        public string FuelUnits { get; set; }
        public string Color { get; set; }
        public string PaxOccupancy { get; set; }
    }
}
