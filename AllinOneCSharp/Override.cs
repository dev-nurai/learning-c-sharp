using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    //Override Class vs Hiding Class

    public class BaseClass
    {
        public virtual void PrintClass()
        {
            Console.WriteLine("This is a Base Class");
        }
    }

    public class DerivedClass1 : BaseClass
    {
        public override void PrintClass()
        {
            Console.WriteLine("This is a Derived (Overide-method) Class");
        }
    }

    public class DerivedClass2 : BaseClass
    {
        public new void PrintClass()
        {
            Console.WriteLine("This is a Derived (New-Method) Class");
        }
    }
}
