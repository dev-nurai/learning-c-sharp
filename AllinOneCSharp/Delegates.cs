using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
   
    public delegate void DelegatesMessage(string UsersMessage);
    //class Delegates //Refer Program.cs
    //{
    //public static void DelegatesMessage(string usersMessage)
    //{
    //    Console.WriteLine(usersMessage);
    //}
    //static void DelegatesMessage(string usersMessage)
    //{
    //    Console.WriteLine(usersMessage);
    //}
    //    }


    delegate bool IsPromotable(TCSEmployee empl); //Ask Jitan or Shamshad Bhai
    class TCSEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<TCSEmployee> employeesList, IsPromotable isEligibleToPromote)
        {
            foreach(TCSEmployee employee in employeesList)
            {
                if(isEligibleToPromote(employee)) //If(employee.Experience >=5) Hard Code
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }
    }

}

/*
 Delegates are type safe function pointer.
    In C#, a delegate is a type that defines a method signature.
    It can be used to pass methods as arguments to other methods, or to define callback methods.
    Delegates are similar to function pointers in C and C++, but are type-safe and secure.
    They can be used to create events and event handlers in C#,
    and are an important part of the language's support for functional programming.

Same Signature are allowed (void or any but same, also parameters)

Use delegrate when we need function as parameter.

>> Lamda Expression
 */