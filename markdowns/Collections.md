# List

**Syntax**

`List<T> obj = new List<T>();`

Where "T" generic parameter you can pass any data-type or custom class object to this parameter.

@[Exercice]({"stubs": ["Exercises/ListStub.cs"],"command": "TechIo.EqualTest.VerifyProcessToKill"})

::: Solution
Replace **TODO** by this code:
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

@[Exercice]({"stubs": ["Exercises/DictionaryStub.cs"],"command": "TechIo.EqualTest.VerifyCountByAges"})

::: Solution
Replace **TODO** by this code: 

`return (this.Id == other.Id && this.Name == other.Name);`
:::

# LIFO vs FIFO
## Stack
A stack is a collection of type **L**ast **I**n **F**irst **O**ut ("**LIFO**").

**Syntax**

`Stack obj = new Stack();`

@[Sample]({"command": "Collections.Samples.StackSample.Sample"})
## Queue
A queue is a collection of type **F**irst **I**n **F**irst **O**ut ("**FIFO**").

**Syntax**

`Queue obj = new Queue();`

@[Sample]({"command": "Collections.Samples.QueueSample.Sample"})
