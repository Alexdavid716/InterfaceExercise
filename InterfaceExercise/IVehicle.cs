public interface IVehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int NumberOfWheels { get; set; }

    
    public void DisplayDetails();
}