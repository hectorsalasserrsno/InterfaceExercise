using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle,  ICompany
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int Speed { get; set; }
        public bool Motor { get; set; }
        public string Model { get ; set ; }
        public string Make { get ; set ; }
        public bool Trunk { get; set; }
        public bool PassengersConfort { get; set; }

        public void HonkNoise()
        {
            Console.WriteLine("My sister's car honk goes yupiiiii.");
        }

    }

    
        
    
}
