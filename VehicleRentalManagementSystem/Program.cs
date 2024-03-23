class Program
{
    static void Main(string[] args)
    {
        var car = new Car("Model S", "Tesla", 2022, 100, 5, "Electric", "Automatic", false);
        var truck = new Truck("F-150", "Ford", 2021, 75, 100);
        var motorcycle = new Motorcycle("Ninja 1000", "Kawasaki", 2022, 30, 1000, "Gasoline", true);

        var rentalAgency = new RentalAgency();
        rentalAgency.AddVehicle(car);
        rentalAgency.AddVehicle(truck);
        rentalAgency.AddVehicle(motorcycle);

        rentalAgency.RentVehicle(car);

        rentalAgency.DisplayFleetDetails();
        Console.ReadLine();
    }
}