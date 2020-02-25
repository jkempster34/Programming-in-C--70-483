using System;
using System.Collections.Generic;
using System.Text;

namespace CreateAndUseTypes
{
    class Listing_2_2Immutable_DateTime
    {

        /* 
         * DateTime is a structure.
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
