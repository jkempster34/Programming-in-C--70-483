using System;

namespace CreateAndUseTypes
{

    /* 
     * If you want to call methods without any concern over the order of parameters, you can use named
     * parameters. 
     * 
     * When using named parameters, the compiler uses the name of each argument rather than the position, 
     * so they can be entered into the method call in any order. This is also good for documentation, when
     * reading the code, you can see the meaining of each parameter.
     * 
     * Ideally, named parameters should be used for any method with more than one argument. 
     */

    class Listing_2_14_Named_parameters
    {
        static void ReadValue(int low, int high, string prompt)
        {
            Console.WriteLine("Low is: {0}, high is: {1}, prompt is: {2}", low, high, prompt);
        }

        static void Main(string[] args)
        {
            ReadValue(1, 2, "Enter age"); // Not using named parameters
            ReadValue(low: 1, high: 2, prompt: "Enter age"); // Using named parameters in order
            ReadValue(prompt: "Enter age", low: 1, high: 2); // Using named parameters out of order

            Console.ReadKey();
        }
    }
}
