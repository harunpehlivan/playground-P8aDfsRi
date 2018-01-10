using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Exercises
{
    public class ListStubs
    {
        public static List<string> GetListNames()
        {
            var name1 = "Anna";
            var name2 = "John";

            var employees = new List<string>();
            ///TODO: Add all employees names to list 
            employees.Add(name1);
            employees.Add(name2);
            return employees;
        }        
    }
}
