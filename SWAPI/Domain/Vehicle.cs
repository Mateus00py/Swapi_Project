﻿namespace SWAPI.Domain
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string CostInCredits { get; set; }
        public string Length { get; set; }
        public string MaxAtmospheringSpeed { get; set; }
        public string Crew { get; set; }
        public string Passengers { get; set; }
        public string CargoCapacity { get; set; }
        public string Consumables { get; set; }
        public string VehicleClass { get; set; }
        public List<string> Pilots { get; set; }
        public List<string> Films { get; set; }
        public string Url { get; set; }
    }
    public class Vehiclelist
    {
        public List<Vehicle> Results { get; set; }
    }
}