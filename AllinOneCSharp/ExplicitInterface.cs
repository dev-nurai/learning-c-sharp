using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    interface I1
    {
        void InterFaceMethod();
    }

    interface I2
    {
        void InterFaceMethod();
    }
    interface I3
    {
        void InterFaceMethod();
    }

    class ExplicitInterFace : I1, I2, I3
    {
        //public void InterFaceMethod()
        //{
        //    Console.WriteLine("This is T1 Method");
        //}

        public void InterFaceMethod() //Default Method in Explicit Method
        {
            Console.WriteLine("This is T1 Method");
        }

        void I2.InterFaceMethod() //Explicit Method [ I1.InterfaceMethod() | Access-modifier is not allowed]    
        {
            Console.WriteLine("This is T2 Method");
        }
        void I3.InterFaceMethod()
        {
            Console.WriteLine("This is T3 Method");
        }
    }
}

/*
 Note: When a class explicitly implements, an interface member, the inheritance member can no longer be accessed through class reference
variable, but only through the inheritance reference variable.

 */