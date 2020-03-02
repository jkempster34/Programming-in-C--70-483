using System;

namespace CreateAndUseTypes
{

    /*
     * Value type variables are stored on the stack, an area of memory which is allocated 
     * and removed as the program enters and leaves blocks. A value type variable created during the
     * execution of a block is stored on the local stack frame and then the entire stack frame is 
     * discarded when the block completes (value types have scope). In pther words, in the stack, data is 
     * destroyed when the memory block currently being operated on is terminated. Upon termination, the 
     * block and all its associated variables are deleted.
     * 
     * On the other hand, Reference type variables are allocated memory on a different structure, called the
     * heap. The heap is managed for an entire application. It is required because references may be passed 
     * between method calls as parameters. Objects can only be removed from the heap when garbage collection
     * determines that there are no references to them.
     */


    class Listing_2_05_Creating_a_reference
    {
        class Alien
        {
            public int X;
            public int Y;
            public int Lives;

            public Alien(int x, int y)
            {
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
            Console.WriteLine("x {0}", x);

            Alien[] swarm = new Alien[100];

            for (int i = 0; i < swarm.Length; i++)
            {
                swarm[i] = new Alien(0, 0);
            }

            Console.WriteLine("swarm [0] {0}", swarm[0]);

            Console.ReadKey();
        }


    }
}
