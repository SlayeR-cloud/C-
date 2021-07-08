using System;

namespace InheritanceC
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            
            car.Go();
            bicycle.Go();
        }
    }

    class Vehicle
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