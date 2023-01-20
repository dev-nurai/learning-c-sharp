using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    public class MethodOverloading
    {
        //Method overloading

        //Method can overload base on numbers of parameters; (), (int x, int y);
        //Method can overload base on types of Parameters; (int x, float y, params int[])
        //Method can overload base on Kinds of Parameters (input parameter, output parameter);

        //Signature of method consisits of name of the method, type or kind or number of Parameters;
        //It is not possible to overload the function base on return type or params modifier.


        public void printMethod()
        {
            Console.WriteLine("Method Overloading Class is here!");
        }

        public void Add(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Sum is {0}", firstNumber + secondNumber);
        }
        public void Add(int firstNumber, int secondNumber, int thirdNumber)
        {
            Console.WriteLine("Sum is {0}", firstNumber + secondNumber + thirdNumber);
        }
    }

}
