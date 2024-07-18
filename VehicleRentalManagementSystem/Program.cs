using System;

class Program
{
    static void Main(string[] args)
    {
        RentalAgency rentalAgency = new RentalAgency();

        Car car = new Car
        {
            Model = "Civic",
            Manufacturer = "Honda",
            Year = 2020,
            RentalPrice = 50,
            Seats = 5,
            EngineType = "V4",
            Transmission = "Automatic",
            Convertible = false
        };

        Truck truck = new Truck
        {
            Model = "F-150",
            Manufacturer = "Ford",
            Year = 2019,
            RentalPrice = 70,
            Capacity = 1000,
            TruckType = "Pickup",
            FourWheelDrive = true
        };

        Motorcycle motorcycle = new Motorcycle
        {
            Model = "Ninja",
            Manufacturer = "Kawasaki",
            Year = 2021,
            RentalPrice = 40,
            EngineCapacity = 600,
            FuelType = "Petrol",
            HasFairing = true
        };

        rentalAgency.AddVehicle(car);
        rentalAgency.AddVehicle(truck);
        rentalAgency.AddVehicle(motorcycle);

        Console.WriteLine("Fleet Details:");
        rentalAgency.DisplayFleet();

        rentalAgency.RentVehicle(car, 3);

        Console.WriteLine("\nFleet Details after renting a car:");
        rentalAgency.DisplayFleet();

        Console.WriteLine($"\nTotal Revenue: {rentalAgency.TotalRevenue}");
    }
}
