using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace CarLotSimulator
{
    class Car
    {
        public Car()
        {

        }
        public Car(int year, string make, string model, bool driveable, string engineNoise, string horn)
        {
            Year = year;
            Make = make;
            Model = model;
            IsDriveable = driveable;
            EngineNoise = engineNoise;
            HonkNoise = horn;

        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise()
        {

            
        }

        public void MakeHonkNoise()
        {
                        
                 
        }





    }

}
