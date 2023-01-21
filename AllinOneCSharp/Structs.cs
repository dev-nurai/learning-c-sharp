using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    public struct Patients
    {

        public void Print()
        {
            Console.WriteLine("This is Structs Class.");
        }
        //Struct Private Fields
        private int _id;
        private string _name;

        //Public Properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Constructor
        public Patients(int id, string name)
        {
            this._id = id;
            this._name = name;
        }
         
        //Method
        public void PrintPatientDetails()
        {
            Console.WriteLine("Patient Name is {0} and {1} is the ID", this._name, this._id);
        }
    }
}
