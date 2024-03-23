public class RentalAgency
{
    private List<Vehicle> _fleet;
    public decimal TotalRevenue { get; private set; }

    public RentalAgency()
    {
        _fleet = new List<Vehicle>();
        TotalRevenue = 0;
    }

    public void AddVehicle(Vehicle vehicle)
    {
        _fleet.Add(vehicle);
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        _fleet.Remove(vehicle);
    }

    public void RentVehicle(Vehicle vehicle)
    {
        if (!_fleet.Contains(vehicle))
        {
            Console.WriteLine("The vehicle is not available in the fleet.");
            return;
        }

        TotalRevenue += vehicle.RentalPrice;
        _fleet.Remove(vehicle);
        Console.WriteLine($"Vehicle rented successfully. Total Revenue: {TotalRevenue}");
    }

    public void DisplayFleetDetails()
    {
        Console.WriteLine("Fleet Details:");
        foreach (var vehicle in _fleet)
        {
            vehicle.DisplayDetails();
            Console.WriteLine("-------------------");
        }
    }
}