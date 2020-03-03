using System;

namespace CreateAndUseTypes
{

    /*
     * Generics, often given the name T, are used extensively in C# collections. In the example below, 
     * a stack/reference type (MyStack) is declared which can hold a stack of any type of object. 
     * Generic classes like this encapsulate operations that are not specific to a particular data type.
     * When MyStack is instantiated, the desired type is specified, in this case a string.
     * 
     * As it is below, Mystack can hold any data type. You can however restrict it to only hold certain types. For example,
     * if declared as: class MyStack<T> where T:class, only reference types will be able to be stored, in this case it would 
     * not be possible to store a value type such as an integer. This is refered to as contraints and there are many others.
     */

    class Listing_2_06_Using_Generic_Types
    {
        class MyStack<T>
        {
            int stackTop = 0;
            T[] items = new T[100];

            public void Push(T item)
            {
                if (stackTop == items.Length)
                    throw new Exception("Stack full");
                items[stackTop] = item;
                stackTop++;
            }

            public T Pop()
            {
                if (stackTop == 0)
                    throw new Exception("Stack empty");
                stackTop--;
                return items[stackTop];
            }
        }

        static void Main(string[] args)
        {
            MyStack<string> nameStack = new MyStack<string>();
            nameStack.Push("Rob");
            nameStack.Push("Mary");
            Console.WriteLine(nameStack.Pop());
            Console.WriteLine(nameStack.Pop());

            Console.ReadKey();
        }
    }
}

