using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    public class Cricketer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }
    public class newKeeper : Cricketer
    {
        //Testing for newKeeper object adding in Cricketer List Object.
    }


}

/*
 List is one of the generic collection classes present in System.Collections.Generic namespace.

    A List class can be used to create a collection of any type.
    - List of Integers, Strings, and even Complex Types.
    
    Object stored in the list can be accessed by index
    *******Unlike Arrays, Lists can grow in Size automatically.
    This class also provide methods to search, sort, and manipulate lists.
 
    List Functions
        - Contains() function = Check if an items exists in the list. The method returns True/False (boolean)
        - Exists() function = Check if an items exists in the list based on a condition. Return True/False (boolean)
        - Find() = Searches for an element that matches the conditions defined by the specific lambda expression and returns the first
            first matching item from the list.
        - FindLast() = Searches for an element that matches the conditions defined by the specific lambda expression and returns the first
            Last matching item from the list.
        - FindAll() = Returns all the items from the list that matches the conditions of specifed by the lambda expression.
        - FindIdex() = Return index of the first items that matches the conditions defined by the specific lambda expression
            Overload method available to find the range.
    Convert
        - Convert an Array to List = use ToList()
        - Convert a list to array = use ToArray()
        - Convert a list to Dictionary = use ToDictionary Method


 */