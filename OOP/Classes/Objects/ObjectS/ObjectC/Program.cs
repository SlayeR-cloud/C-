using System;
using ObjectC.Package;

namespace ObjectC
{
    class Program
    {
        static void Main(string[] args)
        {
            // object: an instance of a class
            // objects can have fields & methods
            // (characteristics and actions)
            HumanClass human = new HumanClass("Dave", 19);
            HumanClass human2 = new HumanClass("Navarro", 90);
            ClassRandom classRandom = new ClassRandom(); // instancing an other package class 
            human.Eat();
            human.Sleep();
            // ........
            human2.Eat();
            human2.Sleep();
        }
        
    }
}