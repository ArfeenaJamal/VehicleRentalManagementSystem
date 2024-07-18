using System;
using System.Collections.Generic;

public class RentalAgency
{
    private List<Vehicle> fleet = new List<Vehicle>();
    private decimal totalRevenue;

    public decimal TotalRevenue
    {
        get { return totalRevenue; }
    }

    public void AddVehicle(Vehicle vehicle)
    {
        fleet.Add(vehicle);
        Console.WriteLine("Vehicle added to fleet.");
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        fleet.Remove(vehicle);
        Console.WriteLine("Vehicle removed from fleet.");
    }

    public void RentVehicle(Vehicle vehicle, int days)
    {
        if (fleet.Contains(vehicle))
        {
            fleet.Remove(vehicle);
            totalRevenue += vehicle.RentalPrice * days;
            Console.WriteLine($"Vehicle rented for {days} days. Total revenue now: {totalRevenue}");
        }
        else
        {
            Console.WriteLine("Vehicle not available for rent.");
        }
    }

    public void DisplayFleet()
    {
        foreach (var vehicle in fleet)
        {
            vehicle.DisplayDetails();
            Console.WriteLine();
        }
    }
}
