using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    //Inheritance
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName+ " " + LastName);
        }

    }

    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;
        public void PrintSalary()
        {
            Console.WriteLine(YearlySalary);
        }

    }

    public class PartEmployee : Employee
    {
        public float HourlyRate;
    }

    public class DoctorEmployee : FullTimeEmployee //inheritance of child class. Path - Parent Class >> Child Class >> Child Class
    {
        public string Location;

    }
}
