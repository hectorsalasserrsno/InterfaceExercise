using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle,  ICompany
    {
        public bool SpaceForEightPeople { get; set; }
        public bool FitAbed { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int Speed { get; set; }
        public bool Motor { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }

        public void HonkNoise()
        {
            Console.WriteLine("My mother's SUV honk sounds yiii haaaa.");
        }
    }
}
