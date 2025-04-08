using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

            Car audi = new Car();
            audi.PowerSource = "Electric";
            audi.Extras = "Spoiler";
            audi.Color = "white";
            audi.Country = "Germany";
            audi.Make = "Audi";
            audi.Year = 2022;
            audi.MPG = 0;
            audi.numberOfDoors = 4;
            Console.WriteLine($"I just bought a {audi.Year} {audi.Color} {audi.numberOfDoors}-door {audi.Make} that has a {audi.Extras}. It was made in {audi.Country}. It's an {audi.PowerSource} vehicle so it gets {audi.MPG} MPG!.");
            

            Truck frontier = new Truck();
            frontier.Make = "Nissan";
            frontier.Color = "Slate";
            frontier.FourWheelDrive = "Four Wheel Drive";
            frontier.numberOfDoors = 2;
            frontier.Country = "Japan";
            frontier.Year = 2021;
            frontier.MPG = 22;
            frontier.CoveredTrunk = "Open Trunk";
            Console.WriteLine($"This {frontier.Make} Frontier is a {frontier.Year} {frontier.FourWheelDrive} model in {frontier.Color} with an {frontier.CoveredTrunk}. It hail's from {frontier.Country}, has {frontier.numberOfDoors} doors and gets {frontier.MPG} MPG.");

            SUV jeep = new SUV();
            jeep.Make = "Jeep";
            jeep.Color = "Blue";
            jeep.numberOfDoors = 4;
            jeep.Country = "USA";
            jeep.Year = 2019;
            jeep.MPG = 18;
            jeep.Seats = 6;
            jeep.SunRoof = "has a sun roof";
            Console.WriteLine($"What about this {jeep.Year} {jeep.Color} {jeep.Make}? It's made in the {jeep.Country}, has {jeep.numberOfDoors} doors and gets {jeep.MPG} MPG. You can comfortably seat {jeep.Seats} and it {jeep.SunRoof}.");
        }
    }
}
