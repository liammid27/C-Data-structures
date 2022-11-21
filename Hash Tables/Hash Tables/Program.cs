using System;
using System.Collections;

namespace Hash_Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myHashbrown = new Hashtable();

            myHashbrown.Add("AA", "Liam");
            myHashbrown.Add("AB", "Ian");
            myHashbrown.Add("AC", "Jade");
            myHashbrown.Add("AD", "Amber");

            foreach (DictionaryEntry d in myHashbrown)
            {
                Console.WriteLine("{0} is the hashcode for {1}", d.Key, d.Value);
            }

            myHashbrown.Remove("AB");

            Console.WriteLine("Now without Ian:");

            foreach (DictionaryEntry d in myHashbrown)
            {
                
                Console.WriteLine("{0} is the hashcode for {1}", d.Key, d.Value);
            }

            myHashbrown.Clear();

            Console.WriteLine("Now with nothing:");

            foreach (DictionaryEntry d in myHashbrown)
            {

                Console.WriteLine("{0} is the hashcode for {1}", d.Key, d.Value);
            }

        }
    }
}
