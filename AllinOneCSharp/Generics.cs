using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    internal class Generics
    {
    }

    public class EqualCalculator//<T>  //Class Generic
    {
        //public static bool AreEqual(int Value1, int Value2) //Fails if the user inputs string value
        //public static bool AreEqual(object Value1, object Value2)
        public static bool AreEqual<T>(T Value1, T Value2) //Method Generic
        {
            //return Value2 == Value2;

            return Value1.Equals(Value2);
        }
    }
}

/*
    If the input is Value Type than it will converted in Reference Type in Object, later will be campared.
    Converting "Value Type" to "Reference Type" is called Boxing.
    Every step Boxing will be done. So, efficiency will drop while using the object.
    
    Generics are use when dont know the parameters Type (int or String) and later they are used. So, we use Generics in Method or Class
    to avoid using Object.
 
 */