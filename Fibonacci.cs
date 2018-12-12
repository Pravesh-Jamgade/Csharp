using System;

namespace learn
{
    internal class Fibonacci
    {
        public void generateFibonacci(){
            int a = 0;
            int b = 1;
            int c = 0;
            Console.Write($"{a} {b} ");

            for (int i = 1;i<20 ; i++){
                c = a+b;
                a = b;
                b = c;
                Console.Write($"{c} ");
            }   
        }
    }
}