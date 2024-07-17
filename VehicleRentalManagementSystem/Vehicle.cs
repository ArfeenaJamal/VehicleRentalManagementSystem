public class Vehicle
{
    private string model;
    private string manufacturer;
    private int year;
    private decimal rentalPrice;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Manufacturer
    {
        get { return manufacturer; }
        set { manufacturer = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public decimal RentalPrice
    {
        get { return rentalPrice; }
        set { rentalPrice = value; }
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Model: {Model}, Manufacturer: {Manufacturer}, Year: {Year}, Rental Price: {RentalPrice}");
    }
}
