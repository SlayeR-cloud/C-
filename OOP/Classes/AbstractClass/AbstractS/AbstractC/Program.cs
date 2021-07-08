using System;

namespace AbstractC
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Abstract modifier: indicates missing components or incomplete implementation
            
            // the abstract modifier is used also for prevent users to create an object of a class that has incomplete implementation
            // in this case we dont want that users create a Vehicle object, for that lets change the modifier to abstract keyword
            
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            
            car.Go();
            bicycle.Go();
        }
    }

    abstract class Vehicle
    {
        public int speed = 0;

        public void Go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }

    // use : to inherit from a class
    
    class Car : Vehicle
    {
        public int wheels = 10;
        
    }
    class Bicycle : Vehicle
    {
        public int wheels = 2;
        
    }
}