namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{
    public string PowerSource { get; set; }
    public string Extras { get; set; }
    public int MPG { get; set; }
    public string Color { get; set; }
    public int numberOfDoors { get; set; }
    public int Year { get; set; }
    
    
    public string Make { get; set; }
    public string Country { get; set; }
}