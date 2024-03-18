using System;

public class Car : IVehicle, ICompany
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int NumberOfWheels { get; set; } = 4; 

    
    public bool HasTrunk { get; set; }

   
    public string CompanyName { get; set; }
    public string HeadquartersLocation { get; set; }

   
    public void DisplayDetails()
    {
        Console.WriteLine($"Car Details:");
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
        Console.WriteLine($"Has Trunk: {HasTrunk}");
        Console.WriteLine($"Company Name: {CompanyName}");
        Console.WriteLine($"Headquarters Location: {HeadquartersLocation}");
        Console.WriteLine();
    }
}