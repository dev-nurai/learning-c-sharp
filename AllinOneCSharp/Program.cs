using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using static AllinOneCSharp.Employee;
using static AllinOneCSharp.Sports;
using System;
using System.IO;

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

            //Structs vs Class

            StructsvsClass structsvsClass = new StructsvsClass();
            structsvsClass.ID = 13;
            structsvsClass.Name = "Machine";

            Console.WriteLine("ID = {0} and Name = {1} (Struct Class)", structsvsClass.ID, structsvsClass.Name);

            int i = 10;
            int j = i; //Copying the Value.
            j += 1;

            Console.WriteLine("i = {0} and j = {1}", i, j);

            StructsvsClass structsvsClass1 = structsvsClass; //Copying the reference.
            structsvsClass1.ID = 14;
            structsvsClass1.Name = "Mark";

            Console.WriteLine("ID = {0} and Name = {1} (Struct1 Class)", structsvsClass1.ID, structsvsClass1.Name);

            //Interface

            NewCustomer ICust = new NewCustomer();
            //ICustomer ICust = new NewCustomer(); //Interface reference can be used for Class object
            ICust.Print();

            //Interface - inheritance Chain

            Maths maths = new SubjectScore();
            maths.PrintMathsScore();

            Sci sci = new SubjectScore();
            sci.PrintSciScore();

            //Explicit Interface

            ExplicitInterFace explicitInterFace = new ExplicitInterFace();

            explicitInterFace.InterFaceMethod(); //Using Default Method

            //Using Explicit Mehtod

            //Typecast method
            ((I2)explicitInterFace).InterFaceMethod();
            ((I3)explicitInterFace).InterFaceMethod();


            I2 i2 = new ExplicitInterFace();
            i2.InterFaceMethod();
            I3 i3 = new ExplicitInterFace();
            i3.InterFaceMethod();

            //Abstract Class
            AbstractClass abstractClass = new Abstract();
            abstractClass.Print();

            AbstractvsInterface abs = new Abs();
            abs.PrintAbstract();


            D d = new D();
            d.Print();

            //Multiple Classes

            ClassAB classAB = new ClassAB();
            classAB.MethodA();
            classAB.MethodB();

            //Delegates

            DelegatesMessage getUserMessage = new DelegatesMessage(DelegatesMessage);
            getUserMessage("Hi, This is on Delegates method.");

            static void DelegatesMessage(string usersMessage)
            {
                Console.WriteLine(usersMessage);
            }

            //TCS Example - Delegates

            List<TCSEmployee> tCSEmployees = new List<TCSEmployee>();
            tCSEmployees.Add(new TCSEmployee() { ID = 101, Name = "Hazle", Salary = 10000, Experience = 10 });
            tCSEmployees.Add(new TCSEmployee() { ID = 102, Name = "John", Salary = 4000, Experience = 4 });
            tCSEmployees.Add(new TCSEmployee() { ID = 103, Name = "Tom", Salary = 1000, Experience = 1 });
            tCSEmployees.Add(new TCSEmployee() { ID = 104, Name = "Obama", Salary = 5000, Experience = 5 });

            //Lambda Expression
            TCSEmployee.PromoteEmployee(tCSEmployees, emp => emp.Experience >= 5);

            //IsPromotable isPromotable = new IsPromotable(Promote);
            //TCSEmployee.PromoteEmployee(tCSEmployees, isPromotable);


            //static bool Promote(TCSEmployee tCSEmployee)
            //{
            //    if (tCSEmployee.Experience >= 5)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}

            //Multicast Delegates || + or - approach

            //Function void type

            SampleDelegate del1 = new SampleDelegate(SampleMethodOne); //
            SampleDelegate del2 = new SampleDelegate(SampleMethodTwo);
            SampleDelegate del3 = new SampleDelegate(SampleMethodThree);

            SampleDelegate del4 = del1 + del2 + del3 - del2; //del4, multicast more functions (del1, del2, del3)
            del4(); //del4 is invoked all above function.

            //Multicast Delegates || += or -= approach

            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;
            del += SampleMethodThree;
            del -= SampleMethodOne;

            del();

            //Function int type
            SampleDelegate2 sampleDelegate2 = new SampleDelegate2(SampleMethod1);
            sampleDelegate2 += SampleMethod2;

            int DelegateReturnValue = sampleDelegate2(); //int DelegateReturnValue can hold one value so the last value will be stored.

            Console.WriteLine("DelegateReturnValue = {0}", DelegateReturnValue);

            //Using out Parameters

            SampleDelegate3 sampleDelegate3 = new SampleDelegate3(SampleMethod3);
            sampleDelegate3 += SampleMethod4;

            int DelegateOutputParameterValue = -1;

            sampleDelegate3(out DelegateOutputParameterValue);

            Console.WriteLine("DelegateOutputParameterValue = {0}", DelegateOutputParameterValue);

            //Exception Handling

            //using System;
            //using System.IO; //use this above

            StreamReader streamReader = null; //
            try //The code 
            {
                streamReader = new StreamReader(@"C:\Users\techi\OneDrive\Desktop\letter.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                //streamReader.Close(); is used to close Reading. If the Stream found error then last two lines will work and Reader will
                //be working. To handle this we have added the code in the below finally block.
            }
            catch (FileNotFoundException except) //If any file name change or delete then we will found the error over here
            {
                //Log the details to the DB
                Console.WriteLine("Please check this file {0} exists or deleted?",except.FileName);
            }
            catch (Exception ex) //This is for all general Exception. Above (FileNotFound) is single or particular type.
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace); //Cryptic Message where we can find the Error (line)

            }
            finally //
            {
                if(streamReader != null)
                {
                    streamReader.Close();
                }
                Console.WriteLine("Finally Block Stop the Reader");
            }
            Console.WriteLine("---------------------------------------------------------");

            //Inner Exception Handling

            // --- Check out below
            //try
            //{

            //    try
            //    {
            //        Console.WriteLine("Please enter the First Number");
            //        int firstNumber = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine("Please enter the Second Number");
            //        int secondNumber = Convert.ToInt32(Console.ReadLine());

            //        int result = firstNumber / secondNumber;
            //        Console.WriteLine("Result = {0}", result);
            //    }
            //    catch (Exception exception)
            //    {
            //        string filePath = @"C:\Users\techi\OneDrive\Desktops\store-inner-exception.txt";
            //        if (File.Exists(filePath))
            //        {
            //            StreamWriter streamWriter = new StreamWriter(filePath);
            //            streamWriter.WriteLine(exception.GetType().Name);
            //            streamWriter.WriteLine(exception.Message);
            //            streamWriter.Close();
            //            Console.WriteLine("There is a problem, Please later.");
            //        }
            //        else
            //        {
            //            throw new FileNotFoundException(filePath + " is not present", exception);
            //        }
            //    }
            //}
            //catch (Exception except)
            //{
            //    Console.WriteLine("Current Exception = {0}", except.GetType().Name);//GetType() is used to get Exception type
            //    if (except != null) //
            //    {
            //        Console.WriteLine("Inner Exception = {0}", except.InnerException.GetType().Name); 
            //    }
            //}

            //Custom Exception

            //throw new FileNotFoundException("File x not found"); //.Net have the constructor to show message to FileNotFoundException
           try
            {
                throw new UserAlreadyLoggedInException("Already Logged In - no Dupicate session allowed");
            }
            catch (UserAlreadyLoggedInException userExcept)
            {
                Console.WriteLine(userExcept.Message);
            }

            //Error Handling Abuse

            try
            {
                Console.WriteLine("Please enter Numerator");
                int Numerator;

                bool isNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Numerator);

                if (isNumeratorConversionSuccessful)
                {
                    Console.WriteLine("Please enter Denominator");
                    int Denominator;

                    bool isDenomintorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Denominator);
                    if (isDenomintorConversionSuccessful && Denominator != 0)
                    {
                        int Result = Numerator / Denominator;
                        Console.WriteLine("Result = {0}", Result);
                    }
                    else
                    {
                        if (Denominator == 0)
                        {
                            Console.WriteLine("Denominator cannot be Zero");
                        }
                        else
                        {
                            Console.WriteLine("Denominator should be a valid number from {0} to {1}", Int32.MinValue, Int32.MaxValue);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Numerator should be a valid number from {0} to {1}", Int32.MinValue, Int32.MaxValue);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }


        }

        //Multicast Delegates in void
        public static void SampleMethodOne()
        {
            Console.WriteLine("Sample One invoked");
        }
        public static void SampleMethodTwo()
        {
            Console.WriteLine("Sample Two invoked");
        }
        public static void SampleMethodThree()
        {
            Console.WriteLine("Sample Three invoked");
        }

        //Multicast Delegates in return

        public static int SampleMethod1()
        {
            return 1;
        }
        public static int SampleMethod2()
        {
            return 2;
        }

        //Using out Parameters
        public static void SampleMethod3(out int Number)
        {
            Number = 1;
        }
        public static void SampleMethod4(out int Number)
        {
            Number = 2;
        }
    }

}




