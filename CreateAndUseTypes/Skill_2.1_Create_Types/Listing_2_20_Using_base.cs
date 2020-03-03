using System;

namespace CreateAndUseTypes
{
    class Listing_2_20_Using_base
    {

        /*
         * The base keyword is used to access members of the base class from within a derived class. 
         * 
         * In the example below, we call a method on the base class (DoPrint) that has been overridden by another 
         * method.
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

        class Invoice : Document
        {
            public override void DoPrint()
            {
                Console.WriteLine("Hello from DoPrint in Invoice");
            }
        }

        class PrePaidInvoice : Invoice
        {
            public override void DoPrint()
            {
                base.DoPrint();
                Console.WriteLine("Hello from DoPrint in PrePaidInvoice");
            }
        }

        static void Main(string[] args)
        {
            PrePaidInvoice p = new PrePaidInvoice();
            p.GetDate();
            p.DoPrint();

            Console.ReadKey();
        }
    }
}
