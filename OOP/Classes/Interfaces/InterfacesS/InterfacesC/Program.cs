using System;

namespace InterfacesC
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Interfaces: defines a "contract" that all the classes inheriting from should follow.
             * an interface declares "what a class should have"
             * an inheriting class defines "how it should do it"
             */

            IPrey interfacePrey = new Rabbit();
            interfacePrey.Flee();
            IPredator interfacePredator = new Lion();
            interfacePredator.Hunt();
            
            
            Console.ReadKey();
        }
    }

    // interfaces should have I before the name of the interface
    interface IPrey
    {
        public void Flee();
    }
    interface IPredator
    {
        public void Hunt();
    }

    class Lion : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The Lion is HUNTING!!!");
        }
    }

    // interface uses : same as inherit
    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("Rabbit is running away!!!");
        }
    }

    // implement both interfaces
    class Fish : IPredator, IPrey
    {
        public void Hunt()
        {
            Console.WriteLine("The fish is hunting");
        }

        public void Flee()
        {
            Console.WriteLine("The fish swims away");
        }
    }
}