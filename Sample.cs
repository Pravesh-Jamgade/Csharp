using System;
using System.Globalization;

namespace learn
{
    internal class Sample
    {
        public string Search(){
            string capitalARing = "\u00c5";
            string aRingXYZ = "\u0061\u030a" + "xyz";
            string msg1 = "Search for the target string \"{0}\" in the string \"{1}\". \n";
            string msg2 = "Using the {0} - \"{1}\" culture:";
            string msg3 = "The string to search ends with the target string: {0}";
            bool result = false;
            CultureInfo ci;

            Console.Clear();
            Console.WriteLine(msg1, capitalARing, aRingXYZ);

            ci = new CultureInfo("en-US");
            Console.WriteLine(msg2, ci.DisplayName, ci.Name);

            result = aRingXYZ.StartsWith(capitalARing,false,ci);
            Console.WriteLine(msg3, result);
            
            result = aRingXYZ.StartsWith(capitalARing,true,ci);
            Console.WriteLine(msg3, result);

            ci = new CultureInfo("sv-SE");
            Console.WriteLine(msg2, ci.DisplayName, ci.Name);

            result = aRingXYZ.StartsWith(capitalARing,false,ci);
            Console.WriteLine(msg3,result);
            
            result = aRingXYZ.StartsWith(capitalARing,true,ci);
            Console.WriteLine(msg3, result);


            Console.WriteLine("\n\"StartsWith\" using \"StringComparision\"");

            String title = "The House of the Seven Gables";
            String searchString = "the";
            StringComparison comparison = StringComparison.InvariantCulture;
            Console.WriteLine(" '{0} ' : ",title);
            Console.WriteLine(" Starts with '{0}' ({1:G} comparison) : {2} \n",title,comparison,title.StartsWith(searchString,comparison));


            comparison = StringComparison.InvariantCultureIgnoreCase;
            Console.WriteLine(" '{0} ' : ",title);
            Console.WriteLine(" Starts with '{0}' ({1:G} comparison) : {2} ",title,comparison,title.StartsWith(searchString,comparison));
            
            Console.Clear();
            return "Done Search";

        }
    }
}