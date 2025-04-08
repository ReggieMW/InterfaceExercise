namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    public string CoveredTrunk { get; set; }
    public string FourWheelDrive { get; set; }
    public int MPG { get; set; }
    public string Color { get; set; }
    public int numberOfDoors { get; set; }
    public int Year { get; set; }
    public string Make { get; set; }
    public string Country { get; set; }
}