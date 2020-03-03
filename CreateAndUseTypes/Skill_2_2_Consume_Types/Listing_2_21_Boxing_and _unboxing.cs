using System;

namespace CreateAndUseTypes.Skill_2_2_Consume_Types
{

    /*
     * Boxing involves converting a value type to the type object. Unboxing involves the conversion of
     * an 'object' type to a value type.
     */

    class Listing_2_21_Boxing_and__unboxing
    {
        static void Main(string[] args)
        {
            // the value of 99 is boxed into an object
            object o = 99;

            // the boxed object is unboxed back into an int
            int oVal = (int)o;
            Console.WriteLine(oVal);

            Console.ReadKey();
        }
    }
}
