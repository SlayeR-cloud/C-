using System;

namespace ArrayObjectsC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type[] name = new Type[value]

            Car[] garage = new Car[10];
            Car car1 = new Car("Ferrari", 10);
            Car car2 = new Car("Lamborghini", 50);

            // also can use garage[0] = new Car("Ferrari", 10);
            
            garage[0] = car1;
            garage[1] = car2;
            
            Console.WriteLine(garage[0].model);
            
        }
    }

    class Car
    {
        public String model;
        public int wheels = 4;
        public int doors;

        public Car(String model, int doors)
        {
            this.model = model;
            this.doors = doors;
        }
    }
}