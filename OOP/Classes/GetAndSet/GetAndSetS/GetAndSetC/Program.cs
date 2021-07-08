using System;

namespace GetAndSetC
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* Getters and setters: add security to the class fields by encapsulation
             * they are accessors found within properties
             *
             * Properties: combine aspects of both fields and methods (share name with a field)
             *
             * Get accessor: used to return the property value 
             *
             * Set accessor: used to assign a new value
             *
             * Value keyword: defines the value being assigned by the set (parameter)
             */

            Car car1 = new Car(2000);
            car1.Speed = 10; // assignment (setter)
            Console.WriteLine(car1.Speed); // (getter)


        }
    }

    class Car
    {
        private int speed;

        public Car(int speed)
        {
            this.speed = speed;
        }

        public int Speed
        {
            // using ?: operator
            get { return speed;  }
            set { speed = value > 500 ? 500 : value; }
        }
    }
}