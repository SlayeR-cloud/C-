using System;

namespace ObjectC
{
    public class HumanClass
    {
        private String name;
        private int age;

        public HumanClass(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
}