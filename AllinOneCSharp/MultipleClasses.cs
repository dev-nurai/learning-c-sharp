using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    interface InterfaceA
    {
        void MethodA();
    }
    class ClassA : InterfaceA
    {
        public void MethodA()
        {
            Console.WriteLine("Print Method A");
        }
    }

    interface InterfaceB
    {
        void MethodB();
    }

    class ClassB : InterfaceB
    {
        public void MethodB()
        {
            Console.WriteLine("Print Method B");
        }
    }

    class ClassAB : InterfaceB, InterfaceA 
    {
        ClassA classa = new ClassA();
        ClassB classb = new ClassB();

        public void MethodA()
        {
            classa.MethodA();
        }
        public void MethodB()
        {
            classb.MethodB();
        }
    }


}
