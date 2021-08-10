using System;
using System.Collections.Generic;
using YourGarage.Vehicles.Aircraft;
using YourGarage.Vehicles.Cars;
using YourGarage.Vehicles.Watercraft;

namespace YourGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Build a collection of all vehicles that fly
            var boeing747 = new Boeing747();
            var jetFighter = new JetFighter();
            var aircraft = new List<AircraftBase>() { boeing747, jetFighter};
            //With a single 'foreach', have each vehicle Fly()
            foreach (var craft in aircraft)
            {
                craft.Fly();
            }
            boeing747.TakeOff();
            jetFighter.Jettison();

            //Build a collection of all vehicles that operate on roads
            var maybach = new Maybach();
            var subaru = new SurabuBRZ();
            var cars = new List<Car>() { maybach, subaru };
            //With a single 'foreach', have each road vehicle Drive()
            foreach (var car in cars)
            {
                car.Drive();
            }
            maybach.Steez();
            subaru.PedalDance();

            //Build a collection of all vehicles that operate on water
            var jetSki = new JetSki();
            var yacht = new Yacht();
            var watercraft = new List<WatercraftBase> { jetSki, yacht };
            //With a single 'foreach', have each water vehicle Drive()
            foreach (var craft in watercraft)
            {
                craft.Drive();
            }
            jetSki.Speed();
            yacht.Reflect();
        }
    }
}
