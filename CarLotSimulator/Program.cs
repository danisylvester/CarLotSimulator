using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating car lot for my used cars
            var myCarLot = new CarLot();
            myCarLot.CarsList = new List<Car>();

            // Instantiating my first car.
            var corolla05 = new Car()
            {
                Model = "Corolla",
                Make = "Toyota",
                Year = 2005,
                IsDriveable = true,
                EngineNoise = "klunk klunk",
                HonkNoise = "beep beep"
            };

            myCarLot.CarsList.Add(corolla05); // Adding corolla obj to my car lot list.

            // Instantiating my second car.
            var subaru20 = new Car();
            subaru20.Make = "Subaru";
            subaru20.Model = "Outback";
            subaru20.Year = 2020;
            subaru20.IsDriveable = true;
            subaru20.EngineNoise = "vroom vroom";
            subaru20.HonkNoise = "HONK!";

            myCarLot.CarsList.Add(subaru20); // Adding the subaru obj to my car lot list.

            // Instantiating my third car.
            var jeep00 = new Car(2000, "Jeep", "Rangler", false, "rhrhrhroom", "hoonnk");

            myCarLot.CarsList.Add(jeep00); // Adding the jeep obj to my car lot list.

            // Calling the Car MakeHonkNoise method for each object.
            corolla05.MakeHonkNoise();
            subaru20.MakeHonkNoise();
            jeep00.MakeHonkNoise();

            // Calling the Car MakeEngineNoise method for each object.
            corolla05.MakeEngineNoise();
            subaru20.MakeEngineNoise();
            jeep00.MakeEngineNoise();

            foreach (var car in myCarLot.CarsList)
            {
                Console.Write($"{car.Year} ");
                Console.Write($"{car.Make} ");
                Console.WriteLine($"{car.Model} ");
            }



            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
