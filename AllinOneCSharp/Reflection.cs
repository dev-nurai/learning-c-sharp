using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    public class User
    {
        public int number { get; set; }
        public string name { get; set; }

        public User(int number, string name)
        {
            this.number = number;
            this.name = name;
        }
        public User() 
        {
            this.number = 1;
            this.name = "Gamer";
        }
        public void PrintNumber()
        {
            Console.WriteLine("User Number = {0}", this.number);
        }
        public void PrintName()
        {
            Console.WriteLine("User Name = {0}", this.name);
        }

    }

    //Late Binding using Reflection

    // Use Late Binding only then the Project Classes are not available.

    public class TechUser
    {
        //If the below code is not availale, then use Late binding.
        public string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }

}
/*
 Reflection

    Reflection is the ability of inspecting an Assemblies' metadata at runtime.
    It is used to find all types in an assembly and /or Dynamically invoke methods in an Assembly.
    We can use Reflection to dynamically create an instance of a type, about which we don't have any information at compile time.
    Reflection enables you to use code that is not available at compile time.

    Reflection is use for "Late Binding".
 
    Note: Try to use Early Binding over Late Binding.
 */