using System;
using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClass1 : AssemblyOneClass1
    {
        public void Print()
        {
            AssemblyOneClass1 A1 = new AssemblyOneClass1(); //Taking the reference from the Assembly - 1. Internal is used here.
            A1.__id = 101;

            AssemblyTwoClass1 assemblyTwoClass1 = new AssemblyTwoClass1();
            assemblyTwoClass1.__name = "Gufran";
        }
        
        
    }
}

/*
    How to use internal access-modifier to other Assembly or Project of a same solution
        First give the reference to the required assembly and directry.
            Reference to Project >> Right Click >> Add >> Reference to Project >> Add it
            Type "using AssemblyOne" to get directory reference.
 
 */