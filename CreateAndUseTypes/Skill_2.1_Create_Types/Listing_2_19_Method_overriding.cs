using System;

namespace CreateAndUseTypes
{
    class Listing_2_19_Method_overriding
    {
        /*
         * Method overriding takes place where class hierarchies are used. A method in a base class is
         * overriden by a method in a child class when the child class contains a methods with the same 
         * name and signature, including number and type of parameters. Only methods marked as virtual 
         * can be overriden.
         */

        class Document
        {
            public void GetDate()
            {
                Console.WriteLine("Hello from GetDate in the Document");
            }

            public virtual void DoPrint()
            {
                Console.WriteLine("Hello from DoPrint in Document");
            }
        }

        class Invoice: Document
        {
            public override void DoPrint()
            {
                Console.WriteLine("Hello from DoPrint in Invoice");
            }
        }

        static void Main(string[] args)
        {
            Invoice c = new Invoice();
            c.GetDate();
            c.DoPrint();

            Console.ReadKey();
        }
    }
}
