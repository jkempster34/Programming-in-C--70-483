using System;

namespace CreateAndUseTypes.Skill_2_2_Consume_Types
{

    /*
     * "Narrowing" involves a value converted into a type that has a narrower range of values, such as
     * when a double is converted into an int. A narrowing conversion requires explicit confirmation (casting) from
     * the programmer that the conversion should be performed as there is a risk of data loss (explicit conversion).
     * 
     * "Widening" involves a value converted into a type which has a wider rage of values, such as an int to a double.
     * This does not require a cast and is called implicit conversion.
     * 
     * Casting cannot be use to convert between different types, such as from a string to an int.
     * 
     * In the example below, the Miles class contains an implicit operator called Kilometers; this is suitably implicit 
     * because the conversion is not narrowing. There is also an explicit operator called Miles which requires casting as 
     * the fractional part of the double is truncated. 
     * 
     * Furthermore, the class makes use of user-defined conversion operators. The "operator" keyword declares an operator, 
     * while the "implicit" and "explicit" keywords define the type of conversion
     *
     */

    class Listing_2_23_Type_conversion
    {
        class Miles
        {
            public double Distance { get; }

            public static implicit operator Kilometers(Miles t)
            {
                Console.WriteLine("Implicit converson from miles to kilometers");
                return new Kilometers(t.Distance * 1.6);
            }

            public static explicit operator int(Miles t)
            {
                Console.WriteLine("Explicit coversion from miles to int");
                return (int)(t.Distance + 0.5);
            }

            public Miles(double miles)
            {
                Distance = miles;
            }
        }

        class Kilometers
        {
            public double Distance { get; }

            public Kilometers(double kilometers)
            {
                Distance = kilometers;
            }
        }



        static void Main(string[] args)
        {
            Miles m = new Miles(100);
            Kilometers k = m;
            Console.WriteLine("kilometers: {0}", k.Distance);
            int intMiles = (int)m;
            Console.WriteLine("Int miles: {0}", intMiles);
            Console.ReadKey();
        }
    }

}
