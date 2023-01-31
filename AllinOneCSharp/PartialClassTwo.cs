using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AllinOneCSharp.Program;

namespace AllinOneCSharp
{
    public partial class PartialClass
    {
        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }
    }
}
