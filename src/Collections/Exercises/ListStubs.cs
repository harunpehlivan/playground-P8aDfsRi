using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Exercises
{
    public class ListStubs
    {
        public static List<string> FirstNames(List<string> users)
        {
            // Create list of string with initial size to 3.
            List<string> names = new List<string>(3);

            // Show capacity ; here : 3.
            Console.WriteLine(string.Format("Capacity {0}", names.Capacity));

            // Show number of items ; here : 0.
            Console.WriteLine(string.Format("Count {0}", names.Count));

            /// TODO: 
            /// Add items from users to "names" list 
            /// User equals "Tim" don't need to add, ignore it
            

            foreach (var firstname in names)
            {
                Console.WriteLine(firstname);
            }           

            return names;
        }
    }
}
