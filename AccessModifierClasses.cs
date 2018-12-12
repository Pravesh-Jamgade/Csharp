using System;

namespace learn
{
    public class AccessModifierPublic
    {
        float pi = 3.14F;
        float radius ;

        public AccessModifierPublic(float radius)  
        {
            this.radius = radius;
        }

        public void AreaOfCircle()
        {
            float area = pi*radius*radius;
            Console.WriteLine($"\nArea: {area}");
        }
        
        public void perimeterOfCircleBypass()
        {   
            Console.WriteLine("\nBypass: for protected method");
            perimeterOfCircleProtected();

            Console.WriteLine("\nBypass: for private method");
            perimeterOfCirclePrivate();
        }

         internal void perimeterOfCircleInternal()
        {   
            float perimeter = 2*pi*radius;
            Console.WriteLine($"\nPerimeter: {perimeter}");
        }

        protected void perimeterOfCircleProtected()
        {   
            float perimeter = 2*pi*radius;
            Console.WriteLine($"\nProtected Perimeter: {perimeter}");
        }

        private void perimeterOfCirclePrivate()
        {   
            float perimeter = 2*pi*radius;
            Console.WriteLine($"\nPrivate Perimeter: {perimeter}");
        }

        public static void main(string [] args)
        {
            AccessModifierPublic access = new AccessModifierPublic(45);
            // accessing protected and private method possible inside of same class
            // main class is called from entry point
            access.perimeterOfCircleBypass();

            // if the class itself is containing another class ,they are accessible even if they are other than public
            AccessModifierPrivate accessPrivate = new AccessModifierPrivate();
            accessPrivate.MethodIsPublic();

            AccessModifierProtected accessProtected = new AccessModifierProtected();
            accessPrivate.MethodIsPublic();

            AccessModifierProtectedInternal accessProtectedInternal = new AccessModifierProtectedInternal();
            accessProtectedInternal.MethodIsProtectedInternal();

        }

        // if the class itself is containing another class ,they are accessible even if they are other than public
        private class AccessModifierPrivate
        {
            public void MethodIsPublic()
            {
                Console.WriteLine("Its the public method of private class");
            }

        }

        protected class AccessModifierProtected
        {
            public void MethodIsPublic()
            {
                Console.WriteLine("Its the public method of protected class");
            }
        }

        protected internal class AccessModifierProtectedInternal
        {
            public void MethodIsProtectedInternal()
            {
                Console.WriteLine("Its the public method of protected internal class");
            }
        }
       
    }

   
}