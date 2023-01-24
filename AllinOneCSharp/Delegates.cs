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


    delegate bool IsPromotable(TCSEmployee empl);
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
    Same Signature are allowed (void or any but same, also parameters)

    Use delegrate when we need function as parameter.

    >> Lamda Expression
     */