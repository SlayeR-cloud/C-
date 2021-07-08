using System;

namespace StaticModifierC
{
    class Program
    {
        static void Main(string[] args)
        {
            // a static modifier, means that the member belongs to the class itself rather than to any specific
            // object 
            
            // ex. let's say that "public static counter" is an attribute of a x class, if we update this variable
            // in the constructor, every time we create or instantiate an object this variable will increase, because
            // the variable belongs to the class, not to an object like the normal attributes 
            
            // look the next example:

            Person person1 = new Person("Dave");
            Person person2 = new Person("John");
            Person person3 = new Person("Micol");
            
            // then if we print person number... will be 3 instead of 1, like we expect from a normal attribute
            Console.WriteLine(Person.personNumber);
            // remind that to access a static attribute of a class, its necessary to use first the name of the class, and then 
            // the thing you're searching for.
            
            // also can define methods as static, for example in an class Car we can define a method called StartRace, that 
            // starts the race for all objects of the class
            
            // is used just to use methods of a class without instantiate an object, ex: if we need to use Round method of the class Math
            // just type Math.Round(value), instead of Math math1 = new Math(); and then call to the method.
            
        }

        class Person
        {
            public String name;
            public static int personNumber;

            public Person(String name)
            {
                this.name = name;
                personNumber++;
            }
        }
    }
}