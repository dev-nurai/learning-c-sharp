using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace AllinOneCSharp
{
    public class OptionalParameters
    {

        //Here "params object[] restOfNum" is optional parameters

        //public static void SumOfNum(int firstNum, int secondNum, params object[] restOfNum)

        //Making Method Parameters optional using defaults (using null in [] parameter)
        //public static void SumOfNum(int firstNum, int secondNum, int[] restOfNum = null)

        //Making Method Parameters optional using OptionalAttributes
        public static void SumOfNum(int firstNum, int secondNum, [Optional] int[] restOfNum)
        {
            int result = firstNum + secondNum;

            if (restOfNum != null)
            {
                foreach (int i in restOfNum)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum of = " + result.ToString());
        }

        //Making Method Parameters optional using method overloading
        public static void SumOfNum(int firstNum, int secondNum)
        {
            SumOfNum(firstNum, secondNum, null);
        }

        //Named Parameters

        public static void Test(int a, int b, int c)
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
        }

        //Making Method Parameters optional using OptionalAttributes
    }
}

/*
 Optional Parameters
    - Use Parameter Arrays
    - Method Overloading
    - Specify parameter defaults
    - Use OptionalAttribute that is present in System.Runtime.InteropServices namespace
 
 */