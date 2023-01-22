using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    public struct StructsvsClass
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // ~StructsvsClass() { } //Destructor will not work in Struct.

        //public StructsvsClass() { } //Contructor without parameter will not work.
    }

    //Sealed Class

    public sealed class Customer { }
    //public class OnlineShopper : Customer { } //OnlineShopper will not inHerit from Customer Class because of the sealed.

    //Structs are inHerit sealed type, they can't act as parent type for a type or structs.
}

/*
 
Structs vs Class

A Struct is a value type where as a Class is a reference type.

Value types hold their value in memory where they are declared, but reference types hold a reference to an object in memory.

Objects will store in Heap and their reference will store in Stack.

Struts = Value Type = int, float, enums
Class = Reference Type = interfece, delegates, etc

Structs are stored in Stack, where as Classes stored in Heap

Value types destroyed immediately after that scope lost, where as for reference types only reference variable is lost and object is remain.
Object, later destroyed by garbage collector.

When you copy a struct into another struct, a new copy of that struct gets created and modification on one struct will not  affect the value.

When you copy a class into another class, we only get a copy of the reference variable. Both the reference variables point to the same object on the heap.
So, Operation on one variable will affect the values contained in the other reference variable.

Structs dont have destructor but Class have.

Structs can't inherit from another class where as Class can have.

 */