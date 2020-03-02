using System;

namespace CreateAndUseTypes
{

    /*
     * Code repitition can be avoided by making one constructor call another by use of the keyword "this".
     * In the example below, the parameters of the call of the second constructor are passed into the first
     * constructor along with an additional lives value. In this case, because all of the work is performed 
     * by the call to the first constructor, the actual body of the second constructor is empty.
     */

    class Listing_2_9_Calling_constructors
    {
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

            public Alien(int x, int y) : this(x, y, 3)
            {
            }

            public override string ToString()
            {
                return string.Format("X: {0} Y: {1} Lives: {2}", X, Y, Lives);
            }
        }

        static void Main(string[] args)
        {
            Alien x = new Alien(100, 100);
            Console.WriteLine(x.ToString());

            Console.ReadKey();
        }
    }
}
