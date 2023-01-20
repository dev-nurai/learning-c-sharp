using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{

    public class Student
    {
        public string FirstName = "Robin";
        public string LastName = "Sharma";

        public virtual void StudentName() // Virtual is used, with this we can override the all other Class Calls.
        {
            Console.WriteLine(FirstName+ " " + LastName);
        }
    }

    public class ArtsStudent : Student
    {

        public override void StudentName()
        {
            Console.WriteLine(FirstName+ " " + LastName + " is an Arts Student");
        }
    }

    public class CommerceStudent : Student
    {
        public override void StudentName()
        {
            Console.WriteLine(FirstName+ " " + LastName + " is a Commerce Student");
        }
    }

    public class ScienceStudent : Student
    {
        //    public override void StudentName()
        //    {
        //        Console.WriteLine(FirstName+ " " + LastName + " is a Science Student");
        //    }
    }
}
