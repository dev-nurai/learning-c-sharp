using static AllinOneCSharp.Employee;
using static AllinOneCSharp.Sports;

namespace AllinOneCSharp
{
    public class Program

    {
        public static void Main()
        {

            //Circle  Program -- Starts Here
            Circle C1 = new Circle(5);
            float Area1 = C1.CalculateAreaa();
            Console.WriteLine("Area of first Circle = {0}", Area1);

            Circle C2 = new Circle(9);
            float Area2 = C2.CalculateAreaa();
            Console.WriteLine("Area of second Circle = {0}", Area2);

            Console.WriteLine("Age", Circle.Age);


            Console.WriteLine(C1.yourName); //test

            //Circle  Program -- Ends Here -------------------------

            //Inheritance Pratice Starts Here

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.FirstName = "Gufran";
            fullTimeEmployee.LastName = "Khan";
            fullTimeEmployee.YearlySalary = 250000;
            fullTimeEmployee.PrintFullName();
            fullTimeEmployee.PrintSalary();

            //Inheritance Pratice Ends Here -------------------------

            //Methods Class Call hiding

            Sports SP = new Sports();
            SP.PersonName = "Sachin Tendulkar";
            SP.Gender = "Male";
            SP.SportPersonName();


            Cricter Cricket = new Cricter();
            Cricket.PersonName = "MS Dhoni";
            Cricket.Gender = "Male";
            Cricket.SportPersonName();

            Soccer Football = new Soccer();
            Football.PersonName = "Ronaldo";
            // Football.SportPersonName();
            ((Sports)Football).SportPersonName();

            //Child class can fullfil all responsibility of Parent Class
            //Vice-versa not allowed

            //Eg. Sports Football = new Soccer();

            //Methods Class Call hiding -----------------------------

            //Polymorphism Starts Here

            Student[] _student = new Student[4];

            _student[0] = new Student();
            _student[1] = new ArtsStudent();
            _student[2] = new CommerceStudent();
            _student[3] = new ScienceStudent();

            foreach (Student x in _student)
            {
                x.StudentName();
            }
            //Polymorphism Starts Here------------------------------------

            //Override Class vs Hiding Class

            BaseClass b1Class = new DerivedClass1();
            BaseClass b2Class = new DerivedClass2();

            b1Class.PrintClass();
            b2Class.PrintClass();
            //Override Class vs Hiding Class------------

            //Method overloading


        }
    }

    class Circle
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


    //Method Class hiding in C#

    public class Sports
    {
        public string PersonName;
        public string Gender;
        public void SportPersonName() //Base Class call
        {
            Console.WriteLine(PersonName + " is a Sportsperson.");
        }
    }

    public class Cricter : Sports
    {
        public new void SportPersonName() //Hiding above Base Class call  //if the intention is to hide then use "new" keyword.
        {
            base.SportPersonName(); //Call base Class or Parent class to print.
            Console.WriteLine(PersonName + " is a Cricketer.");
        }
    }

    public class Soccer : Sports
    {
        public new void SportPersonName() //Hiding above Base Class call
        {
            Console.WriteLine(PersonName + " is a Footballer.");
        }
    }

    //Polymorphism

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

    //Override Class vs Hiding Class

    public class BaseClass
    {
        public virtual void PrintClass()
        {
            Console.WriteLine("This is a Base Class");
        }
    }

    public class DerivedClass1 : BaseClass
    {
        public override void PrintClass()
        {
            Console.WriteLine("This is a Derived (Overide-method) Class");
        }
    }

    public class DerivedClass2 : BaseClass
    {
        public new void PrintClass()
        {
            Console.WriteLine("This is a Derived (New-Method) Class");
        }
    }

    //Method overloading

    //Method can overload base on numbers of parameters; (), (int x, int y);
    //Method can overload base on types of Parameters; (int x, float y, params int[])
    //Method can overload base on Kinds of Parameters (input parameter, output parameter);

    //Signature of method consisits of name of the method, type or kind or number of Parameters;
    //It is not possible to overload the function base on return type or params modifier.


    //Properties


}




