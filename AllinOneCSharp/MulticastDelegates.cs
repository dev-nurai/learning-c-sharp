using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    public delegate void SampleDelegate();

    public delegate int SampleDelegate2();

    public delegate void SampleDelegate3(out int Number);
}

/*
    A multicast delegate is a type of delegate in C# that can hold and invoke multiple methods at a time.
    They are commonly used in event-driven programming, where one object can notify multiple other objects of an event.
    For example, a button click event might be handled by multiple event handlers, each of which is invoked when the button is clicked.
    This allows for a more modular and reusable design, as multiple objects can be notified of the same event without
    the need for explicit communication between them.


 */
