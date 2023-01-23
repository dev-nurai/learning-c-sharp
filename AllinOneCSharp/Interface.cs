using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    interface ICustomer
    {
        void Print(); //Declaration
    }
    
    class NewCustomer : ICustomer
    {
        //Implementation
        public void Print() //Same Signature are allowed means If Print() has no parameters then on implementation Print() with parameters will not work
        {
            Console.WriteLine("Interface is here!");
        }
    }

    //Interface InHerit-Chain

    interface Maths
    {
        void PrintMathsScore();
    }

    interface Sci : Maths
    {
        void PrintSciScore();
    }

    public class SubjectScore : Sci
    {
        public void PrintMathsScore()
        {
            Console.WriteLine("Maths Score = 95/100");
        }
        public void PrintSciScore()
        {
            Console.WriteLine("Science Score = 91/100");
        }
    }
}
