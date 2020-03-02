using System;

namespace CreateAndUseTypes
{
    /*
     * If the user of a method with a optional value does not provide a value, the default will be used. 
     */

    class Listing_2_15_Optional_parameters
    {
        static void ReadValue(double low, double high, string prompt = "Default prompt")
        {
            Console.WriteLine("Low is: {0}, high is: {1}, prompt is: {2}", low, high, prompt);
        }

        static void Main(string[] args)
        {
            ReadValue(low: 1, high: 2, prompt: "Enter name");
            ReadValue(low: 1, high: 2);

            Console.ReadKey();
        }
    }

}
