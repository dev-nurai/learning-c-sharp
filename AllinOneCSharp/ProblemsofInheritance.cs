using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{

    //Diamond Problem
    class A
    {
        public virtual void Print() //Base Class
        {
            Console.WriteLine("A is Implemented");
        }

    }
    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("A is Implemented");
        }
    }
    class C : A
    {
        public override void Print()
        {
            Console.WriteLine("C is Implemented");
        }
    }
    class D : B //, A
    {
        public override void Print()
        {
            Console.WriteLine("D is Implemented");
        }
    }
}
//Git karna baki hai