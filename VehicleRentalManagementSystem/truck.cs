public class Truck : Vehicle
{
    private int capacity;
    private string truckType;
    private bool fourWheelDrive;

    public int Capacity
    {
        get { return capacity; }
        set { capacity = value; }
    }

    public string TruckType
    {
        get { return truckType; }
        set { truckType = value; }
    }

    public bool FourWheelDrive
    {
        get { return fourWheelDrive; }
        set { fourWheelDrive = value; }
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Capacity: {Capacity}, Truck Type: {TruckType}, Four Wheel Drive: {FourWheelDrive}");
    }
}
