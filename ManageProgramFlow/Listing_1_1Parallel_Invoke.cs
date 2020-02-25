using System;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow
{
    class Listing_1_1Parallel_Invoke
    {

        /*
         * Parallel Invoke method is used to launch multiple tasks that are going to be executed in parallel.
         * Parallel.Invoke accepts a number of Action delegates and creates a task for each of them.
         * These are replaced with lambdas in this example.
         * Runtime handles all of the scheduling details.
         */

        static void Task1()
        {
            Console.WriteLine("Task 1 starting");
            Thread.Sleep(2000);
            Console.WriteLine("Task 1 ending");
        }

        static void Task2()
        {
            Console.WriteLine("Task 2 starting");
            Thread.Sleep(1000);
            Console.WriteLine("Task 2 ending");
        }

        static void Main(string[] args)
        {
            Parallel.Invoke(() => Task1(), () => Task2());
            Console.WriteLine("Finished processing. Press key to end.");
            Console.ReadKey();
        }
    }
}
