using System;

namespace ToStringC
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToString() = Converts an object to its string representation so that
            // it is suitable for display

            Car car = new Car("Ferrari", "Blue", 4, 2012);
            Console.WriteLine(car);
        }
    }

    class Car
    {
        public String model;
        public String color;
        public int doors;
        public int year;

        public Car(string model, string color, int doors, int year)
        {
            this.model = model;
            this.color = color;
            this.doors = doors;
            this.year = year;
        }

        public override string ToString()
        {
            return "Model: " + model + "\nColor: " + color + "\nDoor number: " + doors + "\nYear: " + year;
        }
    }
}