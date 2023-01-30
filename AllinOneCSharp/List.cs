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
        public string Type { get; set; }

    }

    public class Footballer : IComparable<Footballer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set;}


        //Here we own the Footballer class code so use the Class CompareTo property
        public int CompareTo(Footballer other) 
        {
            //if (this.Salary > other.Salary)
            //    return 1;
            //else if(this.Salary< other.Salary)
            //    return -1;
            //else 
            //    return 0;

            return this.Salary.CompareTo(other.Salary); //Salary is int Type
            //return this.Name.CompareTo(other.Name); //Salary is int Type

        }

        //Use this if we do not own the Class code.
        /*
         * Steps
         1. Implement the IComparer interface
         2. Pass the instance of the class that implements IComparer interface, as an argument to the sort() method.

         */
        public class SortByName : IComparer<Footballer>
        {
           public int Compare(Footballer x, Footballer y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }

        //Sorting a list using Camparison Delegate
        /*
         Sort() has several overloaded method
            - Sort()
            - Sort(sortByName) //IComparer
            - Sort() //Comparison - delegate
         
        Steps
            1. create a function whose signature matches with the signature of System.Comparison delegate.
                - Use this function for the logic to compare. [Check "CompareFootballer" Function].
            2. Create an instance of  the System.Comparison delegate and then pass the name of the Function (step-1) as argument.
                Comparison delegate is pointing to the logic function.
            3. Pass the delegate instance as Argument to the Sort() function.
         */
        //Comparison<Footballer>

        //public static int CompareFootballer(Footballer x, Footballer y) //Steps - 1 Comparison delegates
        //{
        //    return x.Id.CompareTo(y.Id);
        //}
        
        //Alternative methods to Comparison delegates
    }

    /*
     Salary is int data type so we can use CompareTo Property (Check in IComparable)
     
     */
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

    AddRange() - Add() method allows you to add one item at a time to the end of the list, where as "AddRange()" method allow you to add 
        another list of items at the end of the list.
    GetRange() - get the list of items from the list.
    InsertRange() - 
    RemoveRange() - RemoveAt();
                    RemoveAll()
                    RemoveRange();
    TrueForAll() - Return true or False depending on whether if every element in the list matches the conditions define by the
                    specified predicate;
    AsReadOnly() -Return read-only wrapper for the current collections. Client can't do Add or Remove of the items.

    TrimExcess() - Sets the capacity of the actual number of the elements in the list, if that number is less than a threshold value;




 */