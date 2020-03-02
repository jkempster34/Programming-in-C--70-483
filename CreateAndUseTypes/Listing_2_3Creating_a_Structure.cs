using System;

namespace CreateAndUseTypes
{

    /*
     * When you create a struct object using the new operator, it gets created and the appropriate constructor is called. Unlike classes,
     * structs can be instantiated without using the new operator. If you do not use new, the fields will remain unassigned and the object 
     * cannot be used until all of the fields are initialized. When new is not used, you have to initialise all fields manually, see Alien a 
     * below.
     * 
     * Structs cannot contain explicit parameterless constructors.
     * Also, the constructor of a struct must intialise all data members of the structure. 
     * 
     * Despite this, a struct can be initialized by calling a parameterless constructor, when this is done the elements
     * are set to default values for that type (numeric elements set to zero, strings set to null). 
     * An example of this is the swarm created below.
     */

    struct Alien
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

        // public Alien() { } // This explicit parameterless constructor is not allowed.

        public override string ToString()
        {
            return string.Format("X: {0} Y: {1} Lives: {2}", X, Y, Lives);
        }
    }

    class Listing_2_3Creating_a_Structure
    {
        static void Main(string[] args)
        {
            Alien a;
            a.X = 50;
            a.Y = 50;
            a.Lives = 3;
            Console.WriteLine("a {0}", a.ToString());

            Alien x = new Alien(100, 100);
            Console.WriteLine("x {0}", x.ToString());

            Alien[] swarm = new Alien[100];
            Console.WriteLine("swarm [0] {0}", swarm[0].ToString());

            Console.ReadKey();
        }
    }
}
