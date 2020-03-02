using System;
using System.Collections.Generic;
using System.Text;

namespace CreateAndUseTypes
{
    class Listing_2_1_Value_and_reference_types
    {

        /*
         * Struct is a value type whereas Class is a reference type.
         * When a struct is assigned to a new variable, all the data is copied, and any 
         * modification to the new copy does not change the data for the original copy.
         * In the following example we create an instance of a structure and then assign that instance 
         * to another variable, the instance is copied, and we end up with two instances of the same structure.
         * On the other hand, because class variables are managed by reference, both xClass and yClass refer
         * to the same object. So, changing data in one will affect the data refered to in the other.
         * 
         * Example of value type is DateTime. Example of reference type is Bitmap. Because a bitmap image can be
         * millions of pixels, copying a bitmap if it was a value type would be demanding. Instead, becuase it is managed 
         * by reference, copying simply involves a copy of the reference.
         */

        struct StructStore
        {
            public int Data { get; set; }
        }

        class ClassStore
        {
            public int Data { get; set; }
        }

        static void Main(string[] args)
        {
            StructStore xs, ys;
            ys = new StructStore();
            ys.Data = 99;
            xs = ys;
            xs.Data = 100;
            Console.WriteLine("xStruct: {0}", xs.Data);
            Console.WriteLine("yStruct: {0}", ys.Data);

            ClassStore xc, yc;
            yc = new ClassStore();
            yc.Data = 99;
            xc = yc;
            xc.Data = 100;
            Console.WriteLine("xClass: {0}", xc.Data);
            Console.WriteLine("yClass: {0}", yc.Data);

            Console.ReadKey();
        }
    }
}
