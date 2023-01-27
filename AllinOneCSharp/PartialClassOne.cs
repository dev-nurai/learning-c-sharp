using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    //keyword partial is used to create a partial class
    public partial class PartialClass
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
    


 
 */
