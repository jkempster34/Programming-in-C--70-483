using System;

namespace CreateAndUseTypes
{

    /*
     * Indexers allow you to create a struct, class, or interface that can be accessed like an array for their
     * private collection. 
     * 
     * Indexers are defined in the same way as a property but using the 'this' keyword and square brackets.
     */

    class Listing_2_16_Indexed_properties
    {
        class IntArrayWrapper
        {
            // Create an array to store the values
            private int[] array = new int[100];

            // Declare an indexer property
            public int this[int i]
            {
                get { return array[i]; }
                set { array[i] = value; }
            }
        }

        static void Main(string[] args)
        {
            IntArrayWrapper x = new IntArrayWrapper();
            x[0] = 99;
            Console.WriteLine(x[0]);
            Console.ReadKey();
        }
    }
}
