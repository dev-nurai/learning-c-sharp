using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    public class Circle
    {
        public static float _PI; //Static initializor
        int _Radius; //instance
        public static float Age = 20;

        public string yourName = "Ravi";

        static Circle() //Static Constructor
        {
            Console.WriteLine("Static Constructor");
            Circle._PI = 3.141F;
        }

        public Circle(int radius) //Instance Constructor
        {
            Console.WriteLine("instance Constructor");
            this._Radius = radius;
        }

        public float CalculateAreaa()
        {
            return Circle._PI * this._Radius * this._Radius;
        }

    }
}
