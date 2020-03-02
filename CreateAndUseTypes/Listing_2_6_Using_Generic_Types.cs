using System;
using System.Collections.Generic;
using System.Text;

namespace CreateAndUseTypes
{
    class Listing_2_6_Using_Generic_Types
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

