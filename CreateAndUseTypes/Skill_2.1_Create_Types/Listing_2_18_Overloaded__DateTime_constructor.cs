using System;

namespace CreateAndUseTypes
{

    /*
     * Overloading means to provide a method with the same name, but a different signature. 
     * 
     * DateTime has a large number of overloaded constructors as there are many ways a programmer may want to initialise a
     * DateTime value. Two examples can be seen below. 
     */

    class Listing_2_18_Overloaded__DateTime_constructor
    {
        static void Main(string[] args)
        {
            DateTime d0 = new DateTime(ticks: 636679008000000000);
            DateTime d1 = new DateTime(year: 2018, month: 7, day: 23);
            Console.WriteLine(d0);
            Console.WriteLine(d1);
            Console.ReadKey();
        }
    }
}
