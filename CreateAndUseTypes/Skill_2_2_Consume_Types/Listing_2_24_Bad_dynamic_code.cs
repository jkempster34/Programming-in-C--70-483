using System;

namespace CreateAndUseTypes.Skill_2_2_Consume_Types
{

    /*
     * At compile time, an object of tyoe dynamic is assumed to support any type of operation. This is useful when an object
     * gets its value from the FOM, or from a dynamic language such as JavaScript.
     * 
     * 
     * In the example below, the variable d is declared as dynamic. Usually this code would not compile because there is 
     * no Banana method which d can call. However, because d was declared dynamic, the program will compile and generate 
     * and exception.
     * 
     * 
     * 
     * 
     */

    class Listing_2_24_Bad_dynamic_code
    {
        class MessageDisplay
        {
            public void DisplayMessage(string message)
            {
                Console.WriteLine(message);
            }
        }

        static void Main(string[] args)
        {
            MessageDisplay m = new MessageDisplay();
            m.DisplayMessage("Hello world");

            dynamic d = new MessageDisplay();
            d.Banana("Hello world");
        }

    }

}
