using System;

namespace CreateAndUseTypes
{

    /*
     * Methods have a signature and a body. The signature defines the method name along with the 
     * type and number of the mothods parameters. It does not include the return type. The body is 
     * the block of code that is performed when the mothod is called.
     * 
     * 
     * 
     */

    class Listing_2_12_Simple_method
    {
        class Alien
        {
            public int X;
            public int Y;
            public int Lives;

            public bool RemoveLives(int livesToRemove)
            {
                Console.WriteLine("RemoveLives called");
                Lives = Lives - livesToRemove;
                
                if(Lives <= 0)
                {
                    Lives = 0;
                    X = -1000;
                    Y = -1000;
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        static void Main(string[] args)
        {
            Alien x = new Alien
            {
                X = 100,
                Y = 100,
                Lives = 3
            };

            Console.WriteLine("Alien x created, their lives are {0}, their position is {1}, {2}", x.Lives, x.X, x.Y);
            x.RemoveLives(10);
            Console.WriteLine("Alien x now has {0} lives, their position is now {1}, {2}", x.Lives, x.X, x.Y);
        }
    }
}
