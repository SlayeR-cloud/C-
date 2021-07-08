using System;

namespace PolymorphismC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism: Greek word that means to "Have many forms", that means that an object can
            // be identified by more than one type. Ex. A dog is an animal, a mammal, a organism.

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            // creating an array of different type of objects 
            
            // any object has his own behavior because his constructor is used
            Vehicle[] vehicles = {car, bicycle, boat};

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }

        }
    }

    class Vehicle
    {
        public virtual void Go()
        {
            Console.WriteLine("Vehicle is running");
        }
    }

    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Car is running");
        }
    }

    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Bicycle is running");
        }
    }

    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Boat is running");
        }
    }
}