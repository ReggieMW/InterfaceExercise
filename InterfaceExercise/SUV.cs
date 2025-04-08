namespace InterfaceExercise;

public class SUV : IVehicle, ICompany
{
    public int Seats { get; set; }
    public string SunRoof { get; set; }
    public int MPG { get; set; }
    public string Color { get; set; }
    public int numberOfDoors { get; set; }
    public int Year { get; set; }
    public string Make { get; set; }
    public string Country { get; set; }
}