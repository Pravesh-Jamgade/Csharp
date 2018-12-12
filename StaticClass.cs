using System;

namespace learn
{
    static class StaticClass
    {   
        // no instance member definition allowed i.e. all members should be static (A)
        static int count = 1 ;

        // static class doesnt allow constructor as its a static i.e. no change allowed

        // static class must contain static method, wont work without it [as in (A)]
        public static void StaticMessage()
        {
            Console.WriteLine("\nHello static World");
        }

        public static void StaticReceivedContact(int a)
        {
            Console.WriteLine($"\nHello static World {a+count}");
        }
    }

    public class ContactStaticClass
    {
        static int count = 0;

        public void generateCount()
        {
            count++;
            Console.WriteLine($"Count: {count}");
        }
        
        public static void main(string [] args)
        {   
            Console.WriteLine("\nFrom ContactStaticClass");

            ContactStaticClass contactSaticClass = new ContactStaticClass();

            contactSaticClass.generateCount();
            
            // call static class method's

            StaticClass.StaticMessage();

            // with parameters
            StaticClass.StaticReceivedContact(count);
        }
    }

}