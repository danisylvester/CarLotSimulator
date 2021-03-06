﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace CarLotSimulator
{
    class Car
    {
        public Car()
        {
            ++CarLot.numberOfCars;
        }
        public Car(int year, string make, string model, bool driveable, string engineNoise, string horn)
        {
            Year = year;
            Make = make;
            Model = model;
            IsDriveable = driveable;
            EngineNoise = engineNoise;
            HonkNoise = horn;
            ++CarLot.numberOfCars;
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine($"{Model} engine noise: {EngineNoise}");
            
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine($"{Model} horn noise: {HonkNoise}");

        }





    }

}
