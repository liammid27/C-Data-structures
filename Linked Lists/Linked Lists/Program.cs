using System;
using System.Collections.Generic;

namespace Linked_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> nameList = new LinkedList<string>();

            Console.WriteLine("Full Name List: ");
            nameList.AddLast("Liam");
            nameList.AddLast("Ian");
            nameList.AddLast("Jade");

            foreach (string str in nameList)
            {
                Console.WriteLine(str);
            }

            if (nameList.Contains("Liam") == true)
            {
                nameList.RemoveFirst();
                Console.WriteLine("\nName List without Liam: ");
                foreach (string str in nameList)
                {
                    Console.WriteLine(str);
                }
            }
            
        }
    }
}
