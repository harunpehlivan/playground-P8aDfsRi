using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Exercises
{
    public class DictionaryStub
    {
        public class Employee : IEquatable<Employee>
        {
            public int Age;
            public string Name;


            public Employee(string name, int age)
            {
                this.Age = age;
                this.Name = name;
            }

            public bool Equals(Employee other)
            {
                return (this.Age == other.Age && this.Name == other.Name);
            }
        }
        
        public static Dictionary<int, List<string>> GetEmployeesByAge(List<Employee> employees)
        {
            var result = new Dictionary<int, List<string>>();
        
            foreach (var e in employees)
            {
                //TO DO: add employes to result, the key must contain age and values are names list who have the same age.
                if(result.ContainsKey(e.Age))
                {
                    result[e.Age].Add(e.Name);
                }
                else
                {
                    result.Add(e.Age, new List<string>() { e.Name });
                }
            }
            return result;
        }
    }
}
