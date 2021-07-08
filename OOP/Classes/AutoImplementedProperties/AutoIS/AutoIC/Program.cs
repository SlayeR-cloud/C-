using System;

namespace AutoIC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Auto-Implemented properties: shortcut when no additional logic is required in the property you do not
            // have to define a field for property, you only have to write get; and/or set; inside the property

            Car car = new Car("Ferrari");
            Console.WriteLine(car.Model);

        }
    }

    class Car
    {
        public Car(String model)
        {
            this.Model = model; // this is the use of AI properties, is used when it's no necessary to do
            // many things with the property.
        }

        // getters/setters name must be the field in Uppercase
        public String Model {get; set;}
    }
}