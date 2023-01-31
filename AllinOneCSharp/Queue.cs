using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    internal class Gamer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}

/*
 Queue Collection class
    The Queue collection class is analogous to a queue at the ATM Machine to withdraw money. The order in which people queue up, will be
    the order in which they will be able to get out of queue and withdraw the money from the ATM. The Queue collection class operates
    in a similar fashion.

    To add items to the end of the queue, use "Enqueue()" method.
    To remove an item that is present at the beginning of the queue, use "Dequeue()" method.
    To check if the item, exist in the queue, use Contains() method.

****
* Foreach loop iterates thru the items in the queue, but will not remove them from the queue.


 
 
 */