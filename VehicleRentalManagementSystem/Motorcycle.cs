public class Motorcycle : Vehicle
{
    private int engineCapacity;
    private string fuelType;
    private bool hasFairing;

    public int EngineCapacity
    {
        get { return engineCapacity; }
        set { engineCapacity = value; }
    }

    public string FuelType
    {
        get { return fuelType; }
        set { fuelType = value; }
    }

    public bool HasFairing
    {
        get { return hasFairing; }
        set { hasFairing = value; }
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Engine Capacity: {EngineCapacity}, Fuel Type: {FuelType}, Has Fairing: {HasFairing}");
    }
}
