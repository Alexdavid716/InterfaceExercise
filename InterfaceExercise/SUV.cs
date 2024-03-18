using System;

public class SUV : IVehicle, ICompany
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int NumberOfWheels { get; set; } = 4; 

    
    public int NumberOfSeats { get; set; }

    
    public string CompanyName { get; set; }
    public string HeadquartersLocation { get; set; }

    
    public void DisplayDetails()
    {
        Console.WriteLine($"SUV Details:");
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
        Console.WriteLine($"Number of Seats: {NumberOfSeats}");
        Console.WriteLine($"Company Name: {CompanyName}");
        Console.WriteLine($"Headquarters Location: {HeadquartersLocation}");
        Console.WriteLine();
    }
}
