using System;

namespace CreateAndUseTypes
{
    class Listing_2_07_Constructors
    {

        /*
         * Constructors can be used with value types (structs) or reference types (classes). A
         * constructor has the same name as the class but no return type.
         * 
         * Constructors can perform validation of their parameters to ensure that any objects that 
         * are created contain valid information. If the validation fails, the constructor must throw an 
         * exception as shown below.
         */

        class Alien
        {
            public int X;
            public int Y;
            public int Lives;

            public Alien(int x, int y)
            {
                if (x < 0 || x < y)
                    throw new ArgumentOutOfRangeException("Invalid position");

                X = x;
                Y = y;
                Lives = 3;
            }

            public override string ToString()
            {
                return string.Format("X: {0} Y: {1} Lives: {2}", X, Y, Lives);
            }
        }

        static void Main(string[] args)
        {
            Alien x = new Alien(100, 100);
            Console.WriteLine("x{0}", x);

            Console.ReadKey();
        }
    }
}
