using System;

namespace CreateAndUseTypes
{

    /*
     * Indexers can also be used with other types.
     * 
     * In the example below, indexers are use to allow some of the elements of an int array to be 
     * accessed by name. 
     */

    class Listing_2_17_Indexing_on_strings
    {
        class NamedIntArray
        {
            private int[] array = new int[100];

            public int this[string name]
            {
                get
                {
                    switch (name)
                    {
                        case "zero":
                            return array[0];
                        case "one":
                            return array[1];
                        default:
                            return -1;
                    }
                }
                set
                {
                    switch (name)
                    {
                        case "zero":
                            array[0] = value;
                            break;
                        case "one":
                            array[1] = value;
                            break;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            NamedIntArray x = new NamedIntArray();
            x["zero"] = 99;
            Console.WriteLine(x["zero"]);
        }
    }
}
