# List

**Syntax**
`List<T> obj = new List<T>();`
Where "T" generic parameter you can pass any data-type or custom class object to this parameter.

@[Exercice]({"stubs": ["Exercises/ListStub.cs"],"command": "TechIo.EqualTest.VerifyCountFirstNames"})

::: Solution
To add users to list name you can use this code: 
`
            foreach(var user in users)
            {
                names.Add(user);
            }
`
or 
`
            firstNameList.AddRange(users);
`
This code can be use to remove "Tim" user: 
`
            if (names.Remove("Tim"))
            {
                Console.WriteLine("Tim has been deleted.");
            }
            else
            {
                Console.WriteLine("Tim hasn't been deleted.");
            }
`
You can combine actions by use this code:
             `
            foreach (var user in users)
            {
                if (!user.Equals("Tim"))
                {
                    names.Add(user);
                }
            }
`
:::

# Dictionary
   Dictionary is a generic collections which works on key and value pairs. Both key and value pair can have different data-types or same data-types or any custom types (i.e. class objects). Dictionary generic collections is a generic concept applied over Hashtable and it provides fast lookups with keys to get values.

**Syntax**
`Dictionary<T, T> obj = new Dictionary<T, T>();`
Where "T" generic parameter you can pass any data-type or custom class object to this parameter.

@[Exercice]({"stubs": ["Exercises/DictionaryStub.cs"],"command": "TechIo.EqualTest.VerifyEquality"})

::: Solution
Change line **16** by this code: `return (this.Id == other.Id && this.Name == other.Name);`
:::
