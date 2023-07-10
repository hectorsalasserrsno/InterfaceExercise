using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public bool BedSize { get; set; }   
        public bool FourWheelGear { get; set; }
        public int Wheels { get ; set; }
        public int Doors { get; set; }
        public int Speed { get; set; }
        public bool Motor { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }

        public void HonkNoise()
        {
            Console.WriteLine("My truck goes pi pi pipi.");
        }
    }
}
