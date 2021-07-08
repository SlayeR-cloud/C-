using System;

namespace OverrideMethodsC
{
    class Program
    {
        static void Main(string[] args)
        {
            // in C# a class can use abstract for create abstract methods that will be override, or
            // can create a normal class adding virtual, to the method that will be override
            
            // the methods that will override needs to have the override keyword after the access modifier
            
            // ex: public virtual void SayHello(){ code }

            Animal animal = new Lion();
            animal.Speak();

        }
    }

    class Animal
    {
        // virtual means that this method can be override
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes \"AAAAAAA\"");
        }
    }

    class Lion : Animal
    {
        // own implementation specific for lion
        public override void Speak()
        {
            Console.WriteLine("The Lion goes rrrrrrrrrrrAAA");
        }
    }
}