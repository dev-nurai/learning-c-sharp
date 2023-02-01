using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using static AllinOneCSharp.Employee;
using static AllinOneCSharp.Sports;
using System;
using System.IO;
using static AllinOneCSharp.Client;
using System.Reflection; //Use for Reflection
using static AllinOneCSharp.Billionaire;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Runtime.CompilerServices;
using static AllinOneCSharp.Footballer;
using System.Collections.ObjectModel;
using System.Diagnostics;


namespace AllinOneCSharp
{
    public class Program

    {
        public static async Task Main()
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

            //Circle  Program -- Ends Here ------------------------------------------------------------------------------------------

            //Inheritance Pratice Starts Here

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.FirstName = "Gufran";
            fullTimeEmployee.LastName = "Khan";
            fullTimeEmployee.YearlySalary = 250000;
            fullTimeEmployee.PrintFullName();
            fullTimeEmployee.PrintSalary();

            //Inheritance Pratice Ends Here ------------------------------------------------------------------------------------------

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
            //Polymorphism Starts Here ------------------------------------------------------------------------------------------

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

            //Properties ------------------------------------------------------------------------------------------

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


            //Structs -----------------------------------------------------------------------------------------------------------

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

            //Structs vs Class ------------------------------------------------------------------------------------------

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

            //Interface ---------------------------------------------------------------------------------------------------

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

            //Abstract Class ------------------------------------------------------------------------------------------
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

            //Delegates --------------------------------------------------------------------------------------------------

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

            //Exception Handling ------------------------------------------------------------------------------------------

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

            //Inner Exception Handling ------------------------------------------------------------------------------------------

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

            //Error Handling Abuse ------------------------------------------------------------------------------------------

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

            //Enums -----------------------------------------------------------------------------------------------------------

            #region Enums

            //#region is used to toggle your reguired fields 

            Client[] client = new Client[3];

            client[0] = new Client
            {
                Name = "Jack Sparrow",
                gender = Gender.Male
            };
            client[1] = new Client
            {
                Name = "Jessica",
                gender = Gender.Female
            };
            client[2] = new Client
            {
                Name = "Loki",
                gender = Gender.Unknow
            };

            foreach(Client client1 in client)
            {
                Console.WriteLine("Name = {0} and Gender = {1}", client1.Name, GetGender(client1.gender));
            }

            //Enums - Values
            short[] Values = (short[])Enum.GetValues(typeof(Gender));
            foreach(short value in Values)
            {
                Console.WriteLine(value);
            }
            //Enums - Names
            string[] Names = Enum.GetNames(typeof(Gender));
            foreach(string name in Names)
            {
                Console.WriteLine(name);
            }

            //Enums - Explicit Cast
            Gender xGender = (Gender)3; 
            int xNum = (int)Gender.Male;
            Console.WriteLine("Enum Explicit Cast Value = {0}", xNum); //Output = 1 (Gender.Male)

            Gender yGender = (Gender)Season.Winter;
            Console.WriteLine("Enums Ex - {0}", yGender); //Output = Unknown (Enum-Gender)

            #endregion

            //Attributes -------------------------------------------------------------------------------------------------

            //Calculator.CalAdd(new List<int>() { 12, 22, 10});

            Console.WriteLine("Sum Hai = {0}", Calculator.CalAdd(12, 10));

            Console.WriteLine("SumOf = {0}", Calculator.CalAdd(new List<int>() { 10, 292, 292 }));


            //Reflections ------------------------------------------------------------------------------------------

            //Find all elements present in Assembly or Project
            Type type = Type.GetType("AllinOneCSharp.User");
            //Type type = typeof(User);
            //User U1 = new User();
            //Type type = U1.GetType();

            Console.WriteLine("Full Name = {0}", type.FullName);
            Console.WriteLine("Just Namespace = {0}", type.Namespace);

            Console.WriteLine();

            //Get All Properties details
            PropertyInfo[] properties1 = type.GetProperties();
            foreach(PropertyInfo property in properties1)
            {
                Console.WriteLine("Properties: {0}", property.Name);
                Console.WriteLine(property.PropertyType.Name);
            }

            Console.WriteLine();

            //Get All Method details
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine("Method: {0}", method.Name);
                Console.WriteLine(method.ReturnType.Name);
            }

            Console.WriteLine();

            //Get All Constructor details
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                //Console.WriteLine("Constructor: {0}", constructor.Name);
                Console.WriteLine(constructor.ToString);
            }

            //Early binding -------
            TechUser techUser = new TechUser();
            string fullName = techUser.GetFullName("Ajay", "Nagar");
            Console.WriteLine(fullName);

            //Late Binding using Reflection--------------

            //First Load the Assembly to get the Class
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            //Load Class
            Type typeTechUser = executingAssembly.GetType("AllinOneCSharp.TechUser");

            //Creating instance of the class
            Object techUserInstance = Activator.CreateInstance(typeTechUser);

            //Method that need to invode
            MethodInfo getFullNameMethod = typeTechUser.GetMethod("GetFullName");

            //Parameters ---------
            string[] parameters = new string[2];
            parameters[0] = "Ajay";
            parameters[1] = "Nagar";

            //Invoke
            string fullNameTechUser = (string)getFullNameMethod.Invoke(techUserInstance, parameters);
            Console.WriteLine(fullNameTechUser);

            //Generics ----------------------------------------------------------------------------------------------------

            //bool Equal = EqualCalculator.AreEqual(10, "10"); 
            bool Equal = EqualCalculator.AreEqual<string>("10", "10"); //Class generic
            //bool Equal = EqualCalculator<string>.AreEqual("10", "10"); //Class generic

            if(Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            //String ----------------------------------------------------------------------------------------------------

            //toString
            int meraNumber = 99;
            Console.WriteLine(meraNumber.ToString());

            Billionaire billionaire = new Billionaire();
            billionaire.firstName = "Elon";
            billionaire.lastName = "Musk";

            Console.WriteLine(billionaire.ToString()); // if we convert string to string using toString, will print "AllinOneCharp.Billionaire
            //Use override toString Class 

            //Equals ------------------------------------------------------------------------------------------

            //Equals-int
            int apple = 1;
            int banana = 1;

            //Console.WriteLine(apple == banana);
            //Console.WriteLine(apple.Equals(banana));

            //Equals-Enums

            Direction direction1 = Direction.East;
            Direction direction2 = Direction.West;

            Console.WriteLine(direction1 == direction2);
            Console.WriteLine(direction1.Equals(direction2));

            //Equals-Objects

            Traveller traveller1 = new Traveller();
            traveller1.firstName = "Vinod";
            traveller1.lastName = "Kumar";

            //Equals Fails here

            //Object is One and Two Reference are Same to Object
            //Traveller traveller2 = traveller1;

            //Objects are different

            Traveller traveller2 = new Traveller();
            traveller2.firstName = "Vinod";
            traveller2.lastName = "Kumar";

            //Here Equals Fails to detect the value camparison. //Equals is not know how to compare so we write Override method.

            Console.WriteLine(traveller1 == traveller2);
            Console.WriteLine(traveller1.Equals(traveller2));

            //toSting() vs Convert.ToString()

            Movie movie = new Movie();
            //Movie movie = null;

            //string movieNaam = movie.ToString();
            string movieNaam1 = Convert.ToString(movie);
            //Console.WriteLine(movieNaam);
            Console.WriteLine(movieNaam1);


            //System.String vs String builder ------------------------------------------------------------------------------------------

            //System.String
            string userString = "Learn";
            userString += " C#";
            userString += " with";
            userString += " Venkat";

            Console.WriteLine(userString);

            //String Builder

            //Add System.Text; in start

            StringBuilder blogger = new StringBuilder("Learn");
            blogger.Append(" Javascript");
            blogger.Append(" fron");
            blogger.Append(" FreeCodeCamp");
            Console.WriteLine(blogger.ToString());


            //Indexers -------------------------------------------------------------------------------------------------------

            Infosys infosys = new Infosys();
            Console.WriteLine("Name of Employee with Id = 2 " + infosys[2]);
            Console.WriteLine("Name of Employee with Id = 3 " + infosys[3]);
            Console.WriteLine("Name of Employee with Id = 5 " + infosys[5]);

            Console.WriteLine("Changing Employee Name");
            
            //Use set access to change the values
            infosys[2] = "2nd Employee Name";
            infosys[3] = "3rd Employee Name";
            infosys[5] = "5th Employee Name";

            Console.WriteLine("Name of Employee with Id = 2 " + infosys[2]);
            Console.WriteLine("Name of Employee with Id = 3 " + infosys[3]);
            Console.WriteLine("Name of Employee with Id = 5 " + infosys[5]);

            //Changing Gender in database

            Console.WriteLine("Before Changing the Gender");
            Console.WriteLine("Total Male = " + infosys["Male"]);
            Console.WriteLine("Total Female = " + infosys["Female"]);

            infosys["Male"] = "Female";

            Console.WriteLine("After Changing the Gender");
            Console.WriteLine("Total Male = " + infosys["Male"]);
            Console.WriteLine("Total Female = " + infosys["Female"]);

            //Optional Parameters ------------------------------------------------------------------------------------------

            OptionalParameters.SumOfNum(10, 11, new int[] { 10, 9} );

            //Named Parameter
            OptionalParameters.Test(1, 13, 45);

            //Dicitionary ---------------------------------------------------------------------------------------------------

            Farmer farmer1 = new Farmer()
            {
                ID = 101,
                Name = "Roshan",
                Earning = 5000
            };
            Farmer farmer2 = new Farmer()
            {
                ID = 102,
                Name = "Rajesh",
                Earning = 6100
            };
            Farmer farmer3 = new Farmer()
            {
                ID = 103,
                Name = "Anup",
                Earning = 5800
            };

            Dictionary<int, Farmer> dictionaryFarmers = new Dictionary<int, Farmer>();

            //Add Farmer's object to the dicitonary
            dictionaryFarmers.Add(farmer1.ID, farmer1);
            dictionaryFarmers.Add(farmer2.ID, farmer2);
            dictionaryFarmers.Add(farmer3.ID, farmer3);

            //Find 

            Farmer farmerid102 = dictionaryFarmers[102];
            Console.WriteLine("Farmer ID = {0}, Name = {1}, and Earning = {2}", farmerid102.ID, farmerid102.Name, farmerid102.Earning);

            //Using foreach Loop

            foreach (KeyValuePair<int, Farmer> farmerKeyValuePair in dictionaryFarmers)
            //foreach (var farmerKeyValuePair in dictionaryFarmers) use KeyValuePair for code understanding.
            {
                Console.WriteLine("Key = {0}", farmerKeyValuePair.Key);

                Farmer findFarmer = farmerKeyValuePair.Value;
                Console.WriteLine("Farmer ID = {0}, Name = {1}, and Earning = {2}", findFarmer.ID, findFarmer.Name, findFarmer.Earning);
                Console.WriteLine("---------------------------");

            }
            //Alternative

            //foreach(Farmer findFarmer in dictionaryFarmers.Values)
            //{
            //    Console.WriteLine("Farmer ID = {0}, Name = {1}, and Earning = {2}", findFarmer.ID, findFarmer.Name, findFarmer.Earning);
            //    Console.WriteLine("---------------------------");
            //}

            //Find that keys is available or not

            if(!dictionaryFarmers.ContainsKey(farmer1.ID))
            {
                dictionaryFarmers.Add (farmer1.ID, farmer1);
            }

            //Check key is present or not

            if (dictionaryFarmers.ContainsKey(199))
            {
                Farmer farmerid199 = dictionaryFarmers[199];
            }

            //TryGetValue

            Farmer farmer;
            if(dictionaryFarmers.TryGetValue(101, out farmer))
            {
                Console.WriteLine("ID = {0}, Name = {1}, Earning = {2}", farmer.ID, farmer.Name, farmer.Earning);
            }
            else
            {
                Console.WriteLine("Keys not found!");
            }

            //Count

            Console.WriteLine("Total Count: {0}", dictionaryFarmers.Count());
            Console.WriteLine("Total Count: {0}", dictionaryFarmers.Count(kvp => kvp.Value.Earning > 5500));

            //Remove()
            dictionaryFarmers.Remove(110); //If the Key is unlisted then it won't effect.

            //dictionaryFarmers.Clear(); //Will Clear all

            //Covert Arrays into Dictionary

            Farmer[] arrayOfFarmers = new Farmer[3];
            arrayOfFarmers[0] = farmer1;
            arrayOfFarmers[1] = farmer2;
            arrayOfFarmers[2] = farmer3;

            Dictionary<int, Farmer> dict = arrayOfFarmers.ToDictionary(farm => farm.ID, farm => farm);

            foreach(KeyValuePair<int, Farmer> kvp in dict)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                Farmer far = kvp.Value;
                Console.WriteLine("Array. Id = {0}, Name = {1}, Earning = {2}", far.ID, far.Name, far.Earning);
            }


            //List Class -------------------------------------------------------------------------------------------------

            Cricketer cricketer1 = new Cricketer()
            {
                Id = 12,
                Name = "MS Dhoni",
                Salary = 1500,
                Type = "Men's Cricket"
            };
            Cricketer cricketer2 = new Cricketer()
            {
                Id = 13,
                Name = "Smriti Mandhana",
                Salary = 1000,
                Type = "Women's Cricket"
            };
            Cricketer cricketer3 = new Cricketer()
            {
                Id = 14,
                Name = "Virat Kohli",
                Salary = 1300,
                Type = "Men's Cricket"

            };
            Cricketer cricketer4 = new Cricketer()
            {
                Id = 15,
                Name = "Mithali Raj",
                Salary = 900,
                Type = "Women's Cricket"
            };
            Cricketer cricketer5 = new Cricketer()
            {
                Id = 16,
                Name = "Rohit Sharma",
                Salary = 1000,
                Type = "Men's Cricket"
            };

            List<Cricketer> cricketerList = new List<Cricketer>(2); //Here list of arrays can grow automatically
            cricketerList.Add(cricketer1);
            cricketerList.Add(cricketer2);
            cricketerList.Add(cricketer3);
            cricketerList.Add(cricketer4);
            cricketerList.Add(cricketer5);

            Cricketer cric = cricketerList[1]; //Find the object details using Index

            Console.WriteLine("Cricketer's Id = {0}, Name = {1}, Salary = {2}", cric.Id, cric.Name, cric.Salary);

            Console.WriteLine("Using ForEach Loop-------------------------------------------");

            foreach(Cricketer cricketer in cricketerList)
            {
                Console.WriteLine("Cricketer's Id = {0}, Name = {1}, Salary = {2}", cricketer.Id, cricketer.Name, cricketer.Salary);
            }
            Console.WriteLine("Using For Loop-------------------------------------------");

            for(int icount = 0; icount < cricketerList.Count; icount++)
            {
                Cricketer cricketer = cricketerList[icount];
                Console.WriteLine("Cricketer's Id = {0}, Name = {1}, Salary = {2}", cricketer.Id, cricketer.Name, cricketer.Salary);
            }

            //List is Strongly Type - Means above example is of Object type <Cricketer> so we can't enter Other type...

            //cricketerList.Add(100); //We not added to the List because it's contain Int type.
            //To use

            //newKeeper newKeeper = new newKeeper();

            //cricketerList.Add(newKeeper); //It will add to the list because it's class is inherit from base Class (Cricketer).

            //To Insert Object to any location in the list 
            cricketerList.Insert(0, cricketer4); // This will create new same given object to the given location. List will increase.

            Console.WriteLine("Using Insert------------------------------------------");

            foreach (Cricketer cricketer in cricketerList)
            {
                Console.WriteLine("Cricketer's Id = {0}, Name = {1}, Salary = {2}", cricketer.Id, cricketer.Name, cricketer.Salary);
            }

            Console.WriteLine("Using Retrive------------------------------------------");
            Console.WriteLine("Searching From Start = {0}", cricketerList.IndexOf(cricketer4));
            Console.WriteLine("Searching From Given Index = {0}", cricketerList.IndexOf(cricketer4, 1));
            Console.WriteLine("Searching From Given Index-Range = {0}", cricketerList.IndexOf(cricketer4, 1, 3)); //Output = -1, if not found
            //Console.WriteLine("Searching From Given Index-Range Exd = {0}", cricketerList.IndexOf(cricketer4, 1, 9)); //Fail because "Out of Index-Range"

            //List Functions ------------------------------------------------------------------------------------------------

            //find the items is available or not in the "list"

            //Contians() function - List (Return - bool)

            Console.WriteLine("List Functions------------------------------------------");
            if (cricketerList.Contains(cricketer4))
            {
                Console.WriteLine("Object exists in the list");
            }
            else
            {
                Console.WriteLine("Object does not exists in the list");
            }

            //Exists() function - List (Return - bool)

            if (cricketerList.Exists(cric => cric.Name.StartsWith("Z"))) //Use Lambda expression to find
            {
                Console.WriteLine("Object exists in the list");
            }
            else
            {
                Console.WriteLine("Object does not exists in the list");
            }

            Console.WriteLine("List Find Functions------------------------------------------");
            //Find() function - (Return - single object)

            Cricketer findCricketer = cricketerList.Find(cric => cric.Name.StartsWith("V"));

            Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", findCricketer.Id, findCricketer.Name, findCricketer.Salary);

            //FindLast() function - (Return - single object)

            Cricketer findCricketerlast = cricketerList.FindLast(cric => cric.Salary > 1000);

            Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", findCricketerlast.Id, findCricketerlast.Name, findCricketerlast.Salary);

            //FindAll() function - (Return - All List of object)

            List<Cricketer> findCricketerAll = cricketerList.FindAll(crick => crick.Salary > 1000);

            foreach(Cricketer cricket in findCricketerAll)
            {   
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cricket.Id, cricket.Name, cricket.Salary);
            }

            //FindIndex() function - (Return - index in int)

            int findIndexOfList = cricketerList.FindIndex(1, indcric => indcric.Salary > 1000); //1 represent where to starts

            Console.WriteLine("Index = " + findIndexOfList);

            //FindLastIndex() function - (Return - index in int)
            int findLastIndexOfList = cricketerList.FindLastIndex(1, indcric => indcric.Salary > 1000);

            Console.WriteLine("Index = " + findLastIndexOfList);

            Console.WriteLine("Convert Array to List------------------------------------------");

            //Convert an Array to List = use ToList()
            Cricketer[] newArrayCricketer = new Cricketer[3];
            newArrayCricketer[0] = cricketer1;
            newArrayCricketer[1] = cricketer2;
            newArrayCricketer[2] = cricketer3;

            List<Cricketer> newArrayList = newArrayCricketer.ToList();
            foreach (Cricketer cricket in newArrayList)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cricket.Id, cricket.Name, cricket.Salary);
            }
            Console.WriteLine("Convert list to Array------------------------------------------");

            //Convert a list to array = use ToArray()

            List<Cricketer> lsCricketers = new List<Cricketer>();
            lsCricketers.Add(cricketer1);
            lsCricketers.Add(cricketer2);
            lsCricketers.Add(cricketer3);

            Cricketer[] arrayCricketers = lsCricketers.ToArray();

            foreach(Cricketer cricket in arrayCricketers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cricket.Id, cricket.Name, cricket.Salary);
            }

            Console.WriteLine("Convert list to Dictionary------------------------------------------");

            //Use the same List object

            Dictionary<int, Cricketer> cricketDictionary = lsCricketers.ToDictionary(x => x.Id);
            foreach(KeyValuePair<int, Cricketer> kvp in cricketDictionary)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                Cricketer cricketer = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cricketer.Id, cricketer.Name, cricketer.Salary);
            }

            //Range Methods in List -----------------------------------------------------------------------------------------
            Console.WriteLine("AddRange Methods in List ------------------------------------------");

            List<Cricketer> Cricketlist = new List<Cricketer>();
            Cricketlist.Add(cricketer1);
            Cricketlist.Add(cricketer3);
            Cricketlist.Add(cricketer5);

            List<Cricketer> womensCricketlist = new List<Cricketer>();
            womensCricketlist.Add(cricketer2);
            womensCricketlist.Add(cricketer4);

            //Add Womens Cricketer-list to Mens
            Cricketlist.AddRange(womensCricketlist); //Adding all list of Women's to main list using AddRange

            foreach(Cricketer cricket in Cricketlist)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", cricket.Id, cricket.Name, cricket.Salary, cricket.Type);
            }

            //To retrive items from the list
            Console.WriteLine("GetRange Methods in List ------------------------------------------");

            List<Cricketer> cricketerGetRange = Cricketlist.GetRange(3, 2);

            foreach (Cricketer cricket in cricketerGetRange)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", cricket.Id, cricket.Name, cricket.Salary, cricket.Type);
            }

            //InsertRange of items to the list
            Console.WriteLine("InsertRange Methods in List ------------------------------------------");

            Cricketlist.InsertRange(0, womensCricketlist);

            foreach (Cricketer cricket in Cricketlist)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", cricket.Id, cricket.Name, cricket.Salary, cricket.Type);
            }

            //RemoveRange of items to the list
            Console.WriteLine("RemoveAll Methods in List ------------------------------------------");

            //Cricketlist.Remove(cricketer1); //Will remove single item using Object
            //Cricketlist.RemoveAt(2); //Will remove single item using Index

            Cricketlist.RemoveAll(x => x.Type == "Women's Cricket");

            foreach (Cricketer cricket in Cricketlist)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", cricket.Id, cricket.Name, cricket.Salary, cricket.Type);
            }

            Console.WriteLine("RemoveRange Methods in List ------------------------------------------");
            Cricketlist.RemoveRange(0, 2);
            foreach (Cricketer cricket in Cricketlist)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", cricket.Id, cricket.Name, cricket.Salary, cricket.Type);
            }

            //Sorting
            Console.WriteLine("Sorting the List ------------------------------------------");

            List<int> numbers = new List<int>() { 2, 1,6,3,8,9,4};
            Console.WriteLine("Numbers before Sorting ------------------------------------------");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Sort();
            Console.WriteLine("Numbers After Sorting ------------------------------------------");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            List<string> alphabets = new List<string>() { "D", "J", "Q", "I" };
            Console.WriteLine("alphabets before Sorting ------------------------------------------");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Sort();
            Console.WriteLine("alphabets After Sorting ------------------------------------------");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            //Reverse Sorting
            alphabets.Reverse();
            Console.WriteLine("Reverse alphabets After Sorting ------------------------------------------");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            //Sorting for Complex problems
            Console.WriteLine("Sorting for Complex problems ------------------------------------------");

            Footballer footballer1 = new Footballer()
            {
                Id = 1,
                Name = "Qasim",
                Salary = 7500
            };
            Footballer footballer2 = new Footballer()
            {
                Id = 4,
                Name = "Pooja",
                Salary = 9000
            };
            Footballer footballer3 = new Footballer()
            {
                Id = 2,
                Name = "Ronak",
                Salary = 6500
            };
            Footballer footballer4 = new Footballer()
            {
                Id = 3,
                Name = "Radika",
                Salary = 8000
            };

            List<Footballer> listOfFootballer = new List<Footballer>(100); //initiate Capacity to 100;
            listOfFootballer.Add(footballer1);
            listOfFootballer.Add(footballer2);
            listOfFootballer.Add(footballer3);
            listOfFootballer.Add(footballer4);

            //listOfFootballer.Sort(); //IComparable missing

            //Console.WriteLine("List of Footballers before the Sorting---------------------------------------------");

            //foreach(Footballer footballer in listOfFootballer)
            //{
            //    Console.WriteLine(footballer.Salary);
            //}

            //listOfFootballer.Sort();

            //Console.WriteLine("List of Footballers after the Sorting---------------------------------------------");

            //foreach (Footballer footballer in listOfFootballer)
            //{
            //    Console.WriteLine(footballer.Salary);
            //}

            //Sort by Footballer

            Console.WriteLine("List of Footballers before the Sorting---------------------------------------------");

            foreach (Footballer footballer in listOfFootballer)
            {
                Console.WriteLine(footballer.Salary);
            }

            listOfFootballer.Sort();

            Console.WriteLine("List of Footballers after the Sorting by Salary---------------------------------------------");

            var result = listOfFootballer.OrderBy(x => x.Name).ToList();

            foreach (Footballer footballer in listOfFootballer)
            {
                Console.WriteLine(footballer.Salary);
            }

            SortByName sortByName = new SortByName();

            listOfFootballer.Sort(sortByName);

            Console.WriteLine("List of Footballers after the Sorting by Name---------------------------------------------");

            foreach (Footballer footballer in listOfFootballer)
            {
                Console.WriteLine(footballer.Name);
            }

            //Comparison<Footballer> footballerCompare = new Comparison<Footballer>(CompareFootballer); //Steps - 2 Comparison delegates

            //listOfFootballer.Sort(footballerCompare); //Steps - 3 Comparison delegates

            //Alternative methods using delegates
            //listOfFootballer.Sort(delegate (Footballer f1, Footballer f2) { return f1.Id.CompareTo(f2.Id); });

            //Alternative methods using Lambda expression

            listOfFootballer.Sort((x, y) => x.Id.CompareTo(y.Id));

            Console.WriteLine("List of Footballers after the Sorting by Name---------------------------------------------");

            foreach (Footballer footballer in listOfFootballer)
            {
                Console.WriteLine(footballer.Id);
            }

            //Usefull Methods for list

            //1 - TrueForAll()
            Console.WriteLine("All Salaries are greater than 5000 (TrueForAll) = " + listOfFootballer.TrueForAll(x => x.Salary > 5000));

            //2 - AsReadOnly()
            ReadOnlyCollection<Footballer> readOnlyFootballer =  listOfFootballer.AsReadOnly(); //Use System.Collections.ObjectModel
            Console.WriteLine("Total Items = " + readOnlyFootballer.Count);

            //3 - TrimExcess()

            Console.WriteLine("Capacity before TrimExces = " + listOfFootballer.Capacity);

            listOfFootballer.TrimExcess();
            Console.WriteLine("Capacity After TrimExces = " + listOfFootballer.Capacity);


            //List vs Dicitionary--------------------------------------------------------------------------------------------

            Country country1 = new Country() { CountryCode = "IND", Name = "INDIA", Capital = "DELHI" };
            Country country2 = new Country() { CountryCode = "AUS", Name = "AUSTRALIA", Capital = "CANBERRA" };
            Country country3 = new Country() { CountryCode = "USA", Name = "UNITED STATES", Capital = "WASHINGTON D.C." };
            Country country4 = new Country() { CountryCode = "GBR", Name = "UNITED KINGDOM", Capital = "LONDON" };


            //Using list Method
            //List<Country> countryList = new List<Country>();
            //countryList.Add(country1);
            //countryList.Add(country2);
            //countryList.Add(country3);
            //countryList.Add(country4);


            //string usersChoice = string.Empty;

            //do
            //{
                

            //    Console.WriteLine("Please enter the country-code");
            //    string strCountryCode = Console.ReadLine().ToUpper();

            //    Country resultCountry = countryList.Find(country => country.CountryCode == strCountryCode);

            //    if (resultCountry == null)
            //    {
            //        Console.WriteLine("Country-Code is not valid");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Country = {0}, Captial = {1}", resultCountry.Name, resultCountry.Capital);
            //    }

            //    do
            //    {
            //        Console.WriteLine("Do you want to continue - Yes or No?");
            //        usersChoice = Console.ReadLine().ToUpper();
            //    }
            //    while (usersChoice != "YES" && usersChoice != "NO");

            //}
            //while (usersChoice == "YES");

            //Using Dictionary

            Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();

            dictionaryCountries.Add(country1.CountryCode, country1);
            dictionaryCountries.Add(country2.CountryCode, country2);
            dictionaryCountries.Add(country3.CountryCode, country3);
            dictionaryCountries.Add(country4.CountryCode, country4);

            string usersChoice = string.Empty;

            do
            {


                Console.WriteLine("Please enter the country-code");
                string strCountryCode = Console.ReadLine().ToUpper();

                Country resultCountry = dictionaryCountries.ContainsKey(strCountryCode) ? dictionaryCountries[strCountryCode] : null;

                if (resultCountry == null)
                {
                    Console.WriteLine("Country-Code is not valid");
                }
                else
                {
                    Console.WriteLine("Country = {0}, Captial = {1}", resultCountry.Name, resultCountry.Capital);
                }

                do
                {
                    Console.WriteLine("Do you want to continue - Yes or No?");
                    usersChoice = Console.ReadLine().ToUpper();
                }
                while (usersChoice != "YES" && usersChoice != "NO");


            }
            while (usersChoice == "YES");

            //Queue Collection class ------------------------------------------------------------

            Console.WriteLine("Queue Collection class ------------------------------------------------------------");

            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                Name = "Ajay Nagar",
                Gender = "Male"
            };
            Gamer gamer2 = new Gamer()
            {
                Id = 2,
                Name = "Gaurav Seth",
                Gender = "Male"
            };
            Gamer gamer3 = new Gamer()
            {
                Id = 3,
                Name = "Laxmi Mittal",
                Gender = "Female"
            };
            Gamer gamer4 = new Gamer()
            {
                Id = 4,
                Name = "Shivani Singh",
                Gender = "Female"
            };

            Queue<Gamer> queueGamers = new Queue<Gamer>();

            //Add items using Enqueue() method; will add one-after other
            queueGamers.Enqueue(gamer1);
            queueGamers.Enqueue(gamer2);
            queueGamers.Enqueue(gamer3);
            queueGamers.Enqueue(gamer4);

            //Retrive in Queue

            //Gamer g1 = queueGamers.Dequeue();
            //Console.WriteLine(g1.Id + " - " + g1.Name);
            //Console.WriteLine("Total items in the Queue = " + queueGamers.Count); //Get total items after Dequeue.

            //Gamer g2 = queueGamers.Dequeue();
            //Console.WriteLine(g2.Id + " - " + g2.Name);
            //Console.WriteLine("Total items in the Queue = " + queueGamers.Count);

            //Gamer g3 = queueGamers.Dequeue();
            //Console.WriteLine(g3.Id + " - " + g3.Name);
            //Console.WriteLine("Total items in the Queue = " + queueGamers.Count);

            //Gamer g4 = queueGamers.Dequeue();
            //Console.WriteLine(g4.Id + " - " + g4.Name);
            //Console.WriteLine("Total items in the Queue = " + queueGamers.Count);

            //Retrive in Queue using Foreach
                //Here we can retrive the items without removing it.

            foreach(Gamer gamer in queueGamers)
            {
                Console.WriteLine(gamer.Id + " - " + gamer.Name);
                Console.WriteLine("Total items in the Queue = " + queueGamers.Count);
            }

            Console.WriteLine("Peek Queue ------------------------------------------------------------");

            Gamer pGamer = queueGamers.Peek();

            Console.WriteLine(pGamer.Id + " - " + pGamer.Name);
            Console.WriteLine("Total items in the Queue = " + queueGamers.Count);


            //Gamer pGamer1 = queueGamers.Peek();

            //Console.WriteLine(pGamer1.Id + " - " + pGamer1.Name);
            //Console.WriteLine("Total items in the Queue = " + queueGamers.Count);

            //will give the first item only, no change if we continue.

            //Find  the item is exist or not

            if(queueGamers.Contains(gamer3))
            {
                Console.WriteLine("Gamer Exist");
            }
            else
            {
                Console.WriteLine("Gamer does not Exist");
            }

            //Generic Stack Collection Class

            Console.WriteLine("Generic Stack Collection Class-------------------------------------------------------------");

            Players players1 = new Players()
            {
                Id = 1,
                Name = "Christian Bale",
                Gender = "Male"
            };
            Players players2 = new Players()
            {
                Id = 2,
                Name = "Emma",
                Gender = "Female"
            };
            Players players3 = new Players()
            {
                Id = 3,
                Name = "Jonny Deep",
                Gender = "Male"
            };
            Players players4 = new Players()
            {
                Id = 4,
                Name = "Vin Diesel",
                Gender = "Male"
            };
            Players players5 = new Players()
            {
                Id = 5,
                Name = "Kylie",
                Gender = "Female"
            };

            //Stack will add the last items to the top of the collections. Means last item will be on top and so on.

            Stack<Players> stackPlayers = new Stack<Players>();
            stackPlayers.Push(players1);
            stackPlayers.Push(players2);
            stackPlayers.Push(players3);
            stackPlayers.Push(players4);
            stackPlayers.Push(players5);

            //Retrive or Remove from the TopOf

            Players player1 = stackPlayers.Pop(); //This will retrive and remove the topof the item. Store it.
            Players player2 = stackPlayers.Peek(); //This will retrive and not remove the topof the item. Store it.

            //Console.WriteLine(players1.Id + " - " + players1.Name);
            //Console.WriteLine("Total Items in Stack Collection = {0}", stackPlayers.Count);

            foreach(Players players in stackPlayers)
            {
                Console.WriteLine(players.Id + " - " + players.Name);
                Console.WriteLine("Total Items in Stack Collection = {0}", stackPlayers.Count);
            }

            if(stackPlayers.Contains(players1)) // Check the item is available or not
            {
                Console.WriteLine("Items exist");
            }
            else
            {
                Console.WriteLine("Items does not exist");
            }



            Console.WriteLine("Processor = {0}", Environment.ProcessorCount); //Computer has 4 processor

            //Thread Perfomance

            Stopwatch stopwatch = Stopwatch.StartNew();
            EvenNumbersSum();
            OddNumbersSum();
            stopwatch.Stop();
            Console.WriteLine("Miliseconds without Multiple Thread = " + stopwatch.ElapsedMilliseconds);

            stopwatch = Stopwatch.StartNew();
            Thread T1 = new Thread(EvenNumbersSum);
            Thread T2 = new Thread(OddNumbersSum);

            T1.Start();
            T2.Start();

            T1.Join(); //Join the both method
            T2.Join();

            stopwatch.Stop();
            Console.WriteLine("Miliseconds with Multiple Thread = " + stopwatch.ElapsedMilliseconds);

            //Anonymous Functions

            List<Rider> listOfRiders = new List<Rider>()
            {
                new Rider() { Id = 1, Name = "Mark" },
                new Rider() { Id = 2, Name = "John" },
                new Rider() { Id = 3, Name = "Mary" },
            };

            //Step 2
            //Predicate<Rider> predicateRider = new Predicate<Rider>(FindRider);

            //Step 3
            //Rider rider = listOfRiders.Find(x => FindRider(x));


            //Anonymous 

            //Delegate method
            //Rider rider = listOfRiders.Find(delegate(Rider rid) { return rid.Id == 2; });

            //Lambda expression
            Rider rider = listOfRiders.Find(j => j.Id == 1);

            Console.WriteLine("Id = {0} - Name = {1}", rider.Id, rider.Name);
            //Find more on Anonymous function on Google


            //Async - Await 
            //Change void to Task in Main method()
            
            Stopwatch sw = Stopwatch.StartNew();//To check time

            var tasks = new List<Task> { ReadFile1(), ReadFile2()};
            await Task.WhenAll(tasks);

            sw.Stop();

            Console.WriteLine("Take Taken to read = " + sw.ElapsedMilliseconds);


        }  //---Main() Program ---Ends Here--------------------------------------------------------------------------------



        //Async - Await 
        static async Task<string> ReadFile1() //using <string> because return type is string.
        {
            Console.WriteLine("1.1 - Task executed");

            string readFile1 = await File.ReadAllTextAsync(@"C:\Users\techi\OneDrive\Desktop\jitan-task.txt");

            Thread.Sleep(1000);

            Console.WriteLine($"1.2 - Task executed \n {readFile1}");

            return readFile1;
        }

        static async Task<string> ReadFile2() //using <string> because return type is string.
        {
            Console.WriteLine("2.1 - Task executed");

            string readFile2 = await File.ReadAllTextAsync(@"C:\Users\techi\OneDrive\Desktop\jslogic-code.txt");

            Console.WriteLine($"2.2 - Task executed \n {readFile2}");

            return readFile2;
        }









        //Anonymous method

        //Steps 1
        //public static bool FindRider(Rider rider)
        //{
        //    return rider.Id == 1;
        //}

        public class Rider
        {
            public int Id { get; set; }
            public string Name { get; set; }

        }
























        //Thread Perfomance
        public static void EvenNumbersSum()
        {
            double sum = 0;
            for (int i = 0; i < 5000000; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum of EvenNumbers = {0}", sum);
        }
        public static void OddNumbersSum()
        {
            double sum = 0;
            for (int i = 0; i < 5000000; i++)
            {
                if (i % 2 == 1)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum of OddNumbers = {0}", sum);
        }



        private static void Az1(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public interface IShop
        {
            void IShop();
        }

        //Enums
        public static string GetGender (Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknow:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid Data";
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




