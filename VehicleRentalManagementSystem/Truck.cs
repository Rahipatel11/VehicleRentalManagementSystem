public class Truck : Vehicle
{
    private int v;

    public int Capacity { get; private set; }
    public string TruckType { get; private set; }
    public bool FourWheelDrive { get; private set; }

    public Truck(string model, string manufacturer, int year, decimal rentalPrice, int capacity, string truckType, bool fourWheelDrive)
        : base(model, manufacturer, year, rentalPrice)
    {
        Capacity = capacity;
        TruckType = truckType;
        FourWheelDrive = fourWheelDrive;
    }

    public Truck(string model, string manufacturer, int year, decimal rentalPrice, int v) : base(model, manufacturer, year, rentalPrice)
    {
        this.v = v;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Capacity: {Capacity}");
        Console.WriteLine($"Truck Type: {TruckType}");
        Console.WriteLine($"Four-Wheel Drive: {FourWheelDrive}");
    }
}