using static AllinOneCSharp.Employee;
using static AllinOneCSharp.Sports;

namespace AllinOneCSharp
{
    public class Program

    {
        public static void Main()
        {

            Class1 class1 = new Class1();

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
            MethodOverloading methodOverloading = new MethodOverloading();
            methodOverloading.printMethod();

            methodOverloading.Add(2, 3);
            methodOverloading.Add(2, 3, 9);

            //Properties

            Properties properties = new Properties();
            properties.Print();

            //Setter and Getter Method

            PStudent students = new PStudent();
            students.setID(10);
            students.SetName("John Wick");

            Console.WriteLine("Student Id = {0}", students.GetID());
            Console.WriteLine("Student Name = {0}", students.GetName());
            Console.WriteLine("Student Passing Mark = {0}", students.getPassMark());

            //Using Properties

            students.Id = 1099;
            students.Name = "Atal";
            //students.passMark = 100;  //Will not assign because it is ReadOnly.

            Console.WriteLine("Std ID = {0}", students.Id);
            Console.WriteLine("Std Name = {0}", students.Name);
            Console.WriteLine("Std Passing Marks = {0}", students.passMark);

            //Auto Implemented Properties

            students.Email = "xyz@gmail.com";
            students.City = "Mumbai";

            Console.WriteLine("Std Email = {0}", students.Email);
            Console.WriteLine("Std City = {0}", students.City);


            //Structs

            Patients structs = new Patients(10, "Abdul");
            structs.Print(); //Print message
            structs.PrintPatientDetails(); //Print 1st Patient Details


            Patients patients = new Patients();
            patients.Name = "Ram";
            patients.ID = 11;
            patients.PrintPatientDetails();

            Patients patients1 = new Patients
            {
                Name = "Laxman",
                ID = 12
            };
            
            patients1.PrintPatientDetails();
            

        }
    }

}




