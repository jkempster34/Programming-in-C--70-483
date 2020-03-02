using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow
{
    class Listing_1_02_Parallel_ForEach
    {
        static void WorkOnItem(object item)
        {
            Console.WriteLine("Started working on: " + item);
            Thread.Sleep(100);
            Console.WriteLine("Finished working on: " + item);
        }

        static void Main(string[] args)
        {
            var items = Enumerable.Range(0, 500);
            Parallel.ForEach(items, item => WorkOnItem(item));
        }
    }
}
