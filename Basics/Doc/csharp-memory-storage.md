# C# Memory Storage: Value Types vs Reference Types

## Example Code

```csharp
// Value type example
int age = 20;
int copiedAge = age;
age = 21; // Only 'age' changes, 'copiedAge' remains 20

// Reference type example
class Student 
{
    public string Name { get; set; }
    public int ID { get; set; }
    
    public Student(string name, int id)
    {
        Name = name;
        ID = id;
    }
}

// Usage
Student john = new Student("John", 101);
Student referenceToJohn = john;
john.ID = 102; // Both 'john' and 'referenceToJohn' now have ID 102
```

## Memory Storage Diagram

```
STACK MEMORY                 HEAP MEMORY
-------------                -------------
                           
[age: 21]                  
                           
[copiedAge: 20]            
                                 ┌──────────────────┐
                                 │   Student        │
                                 │   Name: "John"   │
[john: 0x1234] ──────────────>  │   ID: 102        │
                                 └──────────────────┘
                                        ^
[referenceToJohn: 0x1234] ─────────────┘
```

## Explanation

### Value Type (int)
1. When we declare `int age = 20`, the value 20 is stored directly in the stack memory.
2. When we copy it with `int copiedAge = age`, a completely new copy of the value is created in the stack.
3. When we change `age = 21`, only the `age` variable changes; `copiedAge` maintains its own independent value.
4. Both variables have their own memory locations with their own copies of the data.

### Reference Type (Student)
1. When we create `Student john = new Student("John", 101)`:
   - A Student object is created on the heap with the data (Name: "John", ID: 101)
   - The variable `john` on the stack stores only the memory address (0x1234) pointing to that object
2. When we assign `Student referenceToJohn = john`:
   - No new Student object is created
   - `referenceToJohn` stores the same memory address (0x1234)
   - Both variables reference the same object on the heap
3. When we change `john.ID = 102`:
   - The change affects the single object on the heap
   - Both `john` and `referenceToJohn` see the updated value because they point to the same object

This is why modifying a reference type affects all variables referencing that object, while modifying a value type only affects that specific variable.

## Additional Insights

### Memory Allocation
- **Value types**: Memory allocated inline, typically on the stack when used as local variables
- **Reference types**: Memory for the actual object is allocated on the managed heap

### Performance Considerations
- Value types avoid garbage collection overhead
- Reference types avoid copying large data structures

### Common Value Types
- Numeric types (int, float, double)
- bool
- char
- struct
- enum

### Common Reference Types
- class
- interface
- delegate
- string (although it behaves like a value type in many ways)
- array
- collection types (List<T>, Dictionary<K,V>, etc.)
