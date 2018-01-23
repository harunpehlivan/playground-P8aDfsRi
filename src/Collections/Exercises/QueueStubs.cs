using System;
using System.Collections;
using System.Text;

namespace Collections.Exercises
{
    public class QueueStubs
    {

        public static void Sample()
        {
            // Creates and initializes a new Queue.
            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("!");

            // Displays the properties and values of the Queue.
            Console.WriteLine("myQ");
            Console.WriteLine("\tCount:    {0}", myQ.Count);
            Console.Write("\tValues:");
            PrintValues(myQ);
        }

        private static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
            {
                Console.Write("    {0}", obj);
            }
            Console.WriteLine();
        }
    }
}
