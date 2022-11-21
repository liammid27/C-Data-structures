using System;
using System.Collections;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Showing Queue:");
            Queue smallQueue = new Queue();

            smallQueue.Enqueue("Liam");
            smallQueue.Enqueue("Amber");
            smallQueue.Enqueue("Ian");

            Console.WriteLine(smallQueue.Count);

            Console.WriteLine("-----------------");
            Console.WriteLine("Act 1: Names of people within queue");
            smallQueue.ToArray();
            foreach (string str in smallQueue)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("Act 2: Creating and printing second queue");
            Queue carQueue = new Queue();
            carQueue.Enqueue("Audi");
            carQueue.Enqueue("Volkswagen");
            carQueue.Enqueue("BMW");
            foreach (string str in carQueue)
            {
                Console.WriteLine(str);
            }
            carQueue.Dequeue();
            
            Console.WriteLine("\n-Dequeued Audi-");
            foreach (string str in carQueue)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("Act 3:");
            foreach (string str in carQueue)
            {
                Console.WriteLine(str);
            }
            carQueue.Clear();
            if (carQueue.Count == 0)
            {
                Console.WriteLine("Queue is empty, nothing to print");
            }
            foreach (string str in carQueue)
            {
                
                Console.WriteLine(str);
            }


        }


    }
}
