using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            Car car1 = new Car()
            {
               Trunk = true,
               Model = "Tzuru",
               Make = "Nissan",
               Doors = 4
            };
            
            Console.WriteLine($"My {car1.Model} is was made by {car1.Make} and " +
                $"has {car1.Doors} doors, but does it for real has a trunk? {car1.Trunk}");
            
            car1.HonkNoise();

            SUV suv1 = new SUV()
            { 
                SpaceForEightPeople = true,
                Wheels = 4,
                Make = "Volvo",
                FitAbed = true,
            };

            Console.WriteLine($"When I was a kid my family had a {suv1.Make} and had {suv1.Wheels} brand new tires," +
                $" is it true that you can fit a bed in the back?  {suv1.FitAbed}, " +
                $"and does it have space for 8 people? {suv1.SpaceForEightPeople}");

            suv1.HonkNoise();

            Truck truck1 = new Truck()
            { 
                FourWheelGear = true,
                Speed = 100,
                BedSize = true,
                Motor = true,
            };

            Console.WriteLine($"My truck can run as high as {truck1.Speed} miles per hour, " +
                $"does my truck has 4 weel gear?  {truck1.FourWheelGear} ," +
                $"does my truck has a long bedsize? {truck1.BedSize} , " +
                $" does my truck has a great motor? {truck1.Motor}");
            truck1.HonkNoise();

        }
    }
}
