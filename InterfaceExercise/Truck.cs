using System;

public class Truck : IVehicle, ICompany
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int NumberOfWheels { get; set; }

    
    public double PayloadCapacity { get; set; }

    
    public string CompanyName { get; set; }
    public string HeadquartersLocation { get; set; }

    
    public void DisplayDetails()
    {
        Console.WriteLine($"Truck Details:");
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
        Console.WriteLine($"Payload Capacity: {PayloadCapacity} tons");
        Console.WriteLine($"Company Name: {CompanyName}");
        Console.WriteLine($"Headquarters Location: {HeadquartersLocation}");
        Console.WriteLine();
    }
}
