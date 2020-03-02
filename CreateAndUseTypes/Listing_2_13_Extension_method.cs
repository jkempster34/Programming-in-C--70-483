using System;

namespace CreateAndUseTypes
{

    /*
     * Extension methods allow you to "add" methods to an existing class without needing to create a new derived 
     * type, or otherwise modify the existing type
     * 
     * In the example below, we create an extension method to the String class. The first parameter of the
     * method specifies the type that the method should be added to, using the keyword 'this' followed by the
     * name of the type.
     * 
     * The extenison method below is called LineCount and counts the number of lines in a string, returning the 
     * count as an integer. 
     * 
     * Once the extension method is created, it can be used in from the namespace in which the class containing 
     * the method is declared. or by importing the namespace. So, String.LineCount() will only be available in 
     * namespace CreateAndUseTypes.
     */

    static class Listing_2_13_Extension_method
    {
        public static int LineCount(this String str)
        {
            return str.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        static void Main(string[] args)
        {
            string text = @"A rocket explorer called Wright,
                            Once travlled much faster than light,
                            He set out one day,
                            In a relative way,
                            And returned on the previous night";

            Console.WriteLine(text.LineCount());

            Console.ReadKey();
        }
    }
}
