using System.Drawing;
using System.Reflection.Metadata.Ecma335;

namespace InterfaceExercise;

public interface IVehicle
{
    public int MPG { get; set; }
    public string Color { get; set; }
    public int numberOfDoors { get; set; }
    public int Year { get; set; }

    
}