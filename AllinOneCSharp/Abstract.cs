using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    //public abstract sealed class AbstractClass // Sealed are not allowed.
    public abstract class AbstractClass
    {
        public abstract void Print();
    }
    public class Abstract : AbstractClass
    {
        public override void Print() //Why override is used
        {
            Console.WriteLine("Abstract Class is here!!");
        }
    }
}

/*
>> Abstract class are used as Base-Class.
>> Because of the incomplete syntax, we cannot use instance of class.
>> Abstract cannot be sealed.
>> Abstract class may contain abstract members (methods, properties, indexes, and events), but not mandatory.

 ** A non-Abstract class derived from an abstract class must provide implementations for all inherited abstract members.
 
 */