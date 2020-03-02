using System;
using System.Collections.Generic;
using System.Text;

namespace CreateAndUseTypes
{
    class Listing_2_2_Immutable_DateTime
    {

        /* 
         * DateTime is a structure.
         * DateTime is immutable, once you have created an instance of DateTime, you cannot change any elements of that instance.
         * AddDays does not change the contents of a DateTime instance, instead it returns a new System.DateTime
         * that adds the specified number of days to value of this new instance.
         */

        static void Main(string[] args)
        {
            DateTime date = new DateTime();
            date = date.AddDays(1);

            Console.WriteLine(date.ToString());
        }
    }
}
