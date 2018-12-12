using System;
using System.Collections.Generic;

namespace Iterators
{
    public static class ForeachExamples
    {
        public static void ExampleOne()
        {
            var collection = new List<string>
            {
                "Hello",
                "World",
                "Iterators",
                "are",
                "awesome"
            };
            Console.WriteLine("\nInside Iterators namespace");
            Console.WriteLine("\nforeach :\n");
            foreach (var item in collection)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    public class PowerOf2
    {
        public static IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;
            for(int i = 0; i < exponent; i++)
            {
                result = result*number;
                yield return result;
            }
        }

        public static void main(string []args)
        {   
                
                foreach(int i in PowerOf2.Power(2,8))
                {
                    Console.Write("{0} ,",i);
                }
        }

    }

    public static class GalaxyClass
    {
        public static void main(string []args)
        {
            GalaxyClass.ShowGalaxies();
        }
        
        public static void ShowGalaxies()
        {
            var theGalaxies = new Galaxies();
            foreach(Galaxy theGalaxy in theGalaxies.NextGalaxy)
            {
                Console.WriteLine(theGalaxy.Name+" "+theGalaxy.MegaLightYears);
            }
        }

        public class Galaxies
        {
             public IEnumerable<Galaxy> NextGalaxy
             {
                 get
                 {
                        yield return new Galaxy {Name="Tadpole", MegaLightYears=400};
                        yield return new Galaxy {Name="Pinwheel", MegaLightYears=25};
                        yield return new Galaxy {Name="Milky Way", MegaLightYears=0};
                        yield return new Galaxy {Name="Andromeda", MegaLightYears=3};
                 }
             }
        }

        public class Galaxy
        {
                public String Name {get; set;}
                public int MegaLightYears {get; set;}
        }
    }    

}