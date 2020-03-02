using System;

namespace CreateAndUseTypes
{
    class Listing_2_08_Overloaded_constructors
    {

        /*
         * Constructors can have access modifiers, If the constructor is private, the object cannot eb instantiated unless there is a 
         * public factory method. 
         * Constructors can be overloaded, so that an object can have multiple version of a constuctor with different signatures.
         * In the example below, depending on which constructor is called, an Alien will have a particular number of lives, or a 
         * value of three lives.
         */

        class Alien
        {
            public int X;
            public int Y;
            public int Lives;

            public Alien(int x, int y, int lives)
            {
                if (x < 0 || y < 0)
                    throw new ArgumentOutOfRangeException("Invalid position");
                X = x;
                Y = y;
                Lives = lives;
            }

            public Alien(int x, int y)
            {
                X = x;
                Y = y;
                Lives = 3;
            }
        }
    }
}
