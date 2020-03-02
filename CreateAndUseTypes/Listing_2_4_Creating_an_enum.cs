using System;

namespace CreateAndUseTypes
{

    /*
     * Enum is a value type defined by a set of named constants.
     * Used when then is a need to specify a range of values that a given type can have.
     * In this example Alien can have three states: Sleeping, Attacking, or Destroyed.
     * 
     * By default, the associated constant values of enum members are of type int; they start 
     * with zero and increase by one following the definition text order. 
     * To get the integer value from an item, you must explicitly convert the item to an int.
     * 
     * You can assign you own enum values, and the next items will update accordingly.
     */

    class Listing_2_4_Creating_an_enum
    {
        enum AlienState
        {
            Sleeping,   // 0
            Attacking,  // 1
            Destroyed,  // 2
            Eating = 7, // 7
            Drinking    // 8
        }

        static void Main(string[] args)
        {
            AlienState x = AlienState.Attacking;
            Console.WriteLine(x);
            Console.WriteLine((int)x);

            Console.ReadKey();
        }
    }
}
