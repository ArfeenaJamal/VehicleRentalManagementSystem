public class Car : Vehicle
{
    private int seats;
    private string engineType;
    private string transmission;
    private bool convertible;

    public int Seats
    {
        get { return seats; }
        set { seats = value; }
    }

    public string EngineType
    {
        get { return engineType; }
        set { engineType = value; }
    }

    public string Transmission
    {
        get { return transmission; }
        set { transmission = value; }
    }

    public bool Convertible
    {
        get { return convertible; }
        set { convertible = value; }
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Seats: {Seats}, Engine Type: {EngineType}, Transmission: {Transmission}, Convertible: {Convertible}");
    }
}
