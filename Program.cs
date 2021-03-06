﻿using System;
using Iterators;

namespace learn  //app name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Class1 c1 = new Class1();
            Console.WriteLine($"Hello,World {c1.ReturnMessage()} \n");

            Sample sample = new Sample();
            Console.WriteLine($"Search Result : {sample.Search()}");    

            Fibonacci fib = new Fibonacci();
            fib.generateFibonacci();

            AccessModifierPublic classPublic = new AccessModifierPublic(45);
            // public method
            classPublic.AreaOfCircle();

            // internal method
            classPublic.perimeterOfCircleInternal();

            // public method bypass for protected method and private method
            // classPublic.perimeterOfCircleBypass();

            // private method cannot be accessed
            // classPublic.perimeterOfCirclePrivate();

            // protectected method cannot be accessed
            // classPublic.perimeterOfCircleProtected 

            // call main method of another class
            AccessModifierPublic.main(null);            
            
            // static class method cannot be accessed by instance but by classname itself
            StaticClass.StaticMessage();
            
            ContactStaticClass.main(null);

            // from namespace iterators ,accessing static method
            ForeachExamples.ExampleOne();

            // calling main 
            PowerOf2 power = new PowerOf2();
            PowerOf2.main(null);

            // calling main of static class
            GalaxyClass.main(null);

            Console.Clear();

            foreach(var item in IteratorMethods.GetSingleDigitNumbers())
                Console.WriteLine(item);

            foreach(var item in IteratorMethods.GetSingleDigitNumbersV2())
                Console.WriteLine(item);

            Console.WriteLine("\nGeneric Array ");

            GenericArray<int> genericArray = new GenericArray<int>(5);
            genericArray.setItem(0,1);

            Console.WriteLine(genericArray.getItem(0));

            // will produce assertion error by making assertion false message displays
            Console.WriteLine(genericArray.getItem(6));

            Console.Clear();

            
        }
    }
}
