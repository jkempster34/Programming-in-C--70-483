﻿using System;

namespace CreateAndUseTypes
{

    /*
     * Static constructors are called once before the creation of the very first instance of the
     * class. The message below is called before the first Alien was created, and not called 
     * when the second alien is created.
     * 
     * This is a good place to load resources and initialise values that will be used by instances 
     * of the class. 
     */

    class Listing_2_10_Static_constructors
    {
        class Alien
        {
            static Alien()
            {
                Console.WriteLine("Static Alien constructor running");
            }

            public Alien(string name)
            {
                Console.WriteLine("Alien {0} created", name);
            }
        }

        static void Main(string[] args)
        {
            Alien x = new Alien("x");
            Alien y = new Alien("y");
        }
    }
}
