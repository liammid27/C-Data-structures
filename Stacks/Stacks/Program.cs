using System;
using System.Collections;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();

            Console.WriteLine("Names added to list:");
            myStack.Push("Liam");
            myStack.Push("Ian"); 
            myStack.Push("Amber");

            foreach (string str in myStack)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("Act 1: ");
            Console.WriteLine(myStack.Count);
            myStack.Clear();
            Console.WriteLine(myStack.Count);

            Console.WriteLine("Act 2:");

            if (myStack.Contains("Vega"))
            {
                Console.WriteLine("Stack contains Vega");
            }
            else
            {
                Console.WriteLine("Stack doesnt contain Vega");
            }

            Console.WriteLine("Act 3:");
            myStack.Push("Mohammed");
            Console.WriteLine(myStack.Pop());


        }
    }
}
