using System;

namespace EnumsC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enums: is a special class that contains a set of named integer constants.
            
            // use enums when you have values that you know will not change, to get the integer value
            // from a item, you must explicitly convert to an int
            
            // name = integer
            
            // by default if you dont assign any value, the variables will have a progressive value
            
            // 0
            // 1
            // 2
            // 3
            // etc...

            // this will return the name of the variable, can use the ToString() method if you want
            Console.WriteLine(Planet.Mars + " Is a planet");
            // this will return the value corresponding to the variable 
            Console.WriteLine("Planet #" + (int) Planet.Mars);
            
            // if want to store in a string variable have to use the ToString() method

            String planetName = PlanetRadius.Earth.ToString();
            int planetRadio = (int) PlanetRadius.Earth;

            
            Console.WriteLine("Planet: " + planetName + "\nRadio: " + planetRadio);
            Console.WriteLine("Volume: " + Volume(PlanetRadius.Earth));
        }

        public static double Volume(PlanetRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int) radius, 3);
            return volume;
        }
    }

    enum Planet
    {
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune = 8,
        Pluto = 9
    }
    
    enum PlanetRadius
    {
        Mercury = 135,
        Venus = 123122,
        Earth = 31241,
        Mars = 41215,
        Jupiter = 5125125,
        Saturn = 6125,
        Uranus = 41247,
        Neptune = 854564,
        Pluto = 98456
    }
    
}