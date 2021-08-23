namespace YourGarage
{
    interface ICar
    {
        string Color { get; set; }
        int FuelCapacity { get; set; }
        string FuelUnits { get; set; }
        string PaxOccupancy { get; set; }
    }
}