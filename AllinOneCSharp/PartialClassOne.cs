using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static AllinOneCSharp.Program;

namespace AllinOneCSharp
{
    //keyword partial is used to create a partial class
    public partial class PartialClass : IShop
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        { 
            get 
            { 
                return _firstName; 
            }
             set 
            { 
                _firstName = value; 
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public void IShop()
        {
            throw new NotImplementedException();
        }

        partial void SamplePartialMehtod(); //Declaration

        partial void SamplePartialMehtod()
        {
            Console.WriteLine("SamplePartialMethod Invoke");//Implementation
        }

        public void PublicPartialMehtod()
        {
            Console.WriteLine("PublicMethod Invoke");
            SamplePartialMehtod();
        }
    }
}
/*
 Partial Class
    - Use "Partial" Keyword
    - Same access modifiers on all Partial Class
    - If any parts of are declared as Abstract, then the entire type is considered as Abstract.
    - Same for "sealed" Class
    - If any of the parts inherit a class, then the entire type inherit that class.
    - C# Does not support multiple class inheritance.
    - Different parts of the partial class can specify different base interfaces, and the final type implements all
        interfaces listed by all of the partial declarations.
    - Partial Method type must be void.
     Partial methods are private by default.
    - It's a complile time error, to include declaration and implementation at the same time for a partial method.


 
 */
