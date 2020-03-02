using System;

namespace CreateAndUseTypes
{

    /*
     * A static variable is a member of a type, but not created for each instance of a type. In the
     * example below, a static variable is used to store a maximum number of lives for Alien to have.
     * This is a value that should be stored once for all Aliens to have. 
     * 
     * Code outside of the Alien class must refer to the Max_Lives variable via class name, rather than 
     * the name of any class instance (for example, Alien.Max_Lives = 150;)
     * 
     * Making a variable static does not stop the variable being changed when the program is running, instead
     * it makes the varible "always present". So, a program can use this variable without needing to have
     * created any instances of that type. A good use for static variables is how they have been used here, as 
     * a validation value, or for default values.
     * 
     * Further, there also exists staic methods, which likewise can be called without creating an instance of 
     * the object containing the method.  
     */

    class Listing_2_11_Static_variables
    {
        class Alien
        {
            public static int Max_Lives = 99;

            public int X;
            public int Y;
            public int Lives;

            public Alien(int x, int y, int lives)
            {
                if (x < 0 || y < 0)
                    throw new Exception("Invalid position");

                if (lives > Max_Lives)
                    throw new Exception("Invalid lives");

                X = x;
                Y = y;
                Lives = lives;
            }
        }
    }
}
