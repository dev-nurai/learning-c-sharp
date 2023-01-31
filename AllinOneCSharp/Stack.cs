using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    internal class Players
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}

/*
    Generic Stack Collection class
        last items will present at the top of the stack

        - Push() = to insert items on top of the stack
        - Pop() = to remove and return the items that is present at the top of the Stack.
        - Contains() - check the item is available or not 
        - Peek() = Returen the items but will not delete it. 
 
 
 */