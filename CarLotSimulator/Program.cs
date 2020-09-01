using System;
using System.Diagnostics;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var corolla05 = new Car()
            {
                Model = "Corolla",
                Make = "Toyota",
                Year = 2005,
                IsDriveable = true,
                EngineNoise = "klunk klunk",
                HonkNoise = "beep beep"
            };

            var subaru20 = new Car();
            subaru20.Make = "Subaru";
            subaru20.Model = "Outback";
            subaru20.Year = 2020;
            subaru20.IsDriveable = true;
            subaru20.EngineNoise = "vroom vroom";
            subaru20.HonkNoise = "HONK!";

            var jeep00 = new Car(2000, "Jeep", "Rangler", false, "rhrhrhroom", "hoonnk");

            corolla05.MakeHonkNoise();
            subaru20.MakeHonkNoise();
            jeep00.MakeHonkNoise();

            corolla05.MakeEngineNoise();
            subaru20.MakeEngineNoise();
            jeep00.MakeEngineNoise();


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
