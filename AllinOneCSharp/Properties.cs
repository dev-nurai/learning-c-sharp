using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    public class Properties
    {
        public void Print()
        {
            Console.WriteLine("Properties Class is here!");
        }
    }
    public class PStudent
    {
        //public int Id;
        //public string Name;
        //public int passMark;

        //Above class are live to public, everyone can be accwssible and set the value as per their choice;
        //Always initiate your class field with private or public.

        private int _id;
        private string _name;
        private int _passmark = 35;


        //Student Id cannot be negative so use the conditions

        public void setID(int id)
        {
            if(id <= 0)
            {
                throw new Exception("Student Id cannot be Zero or Negative");
            }
            this._id = id;
        }

        public int GetID()
        {
            return this._id;
        }

        //Student Name cannot be null or empty
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this._name = name;
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(this._name) ? "No Name Mentioned" : this._name;
        }

        //Student Passing cannot be changeable (ReadOnly Type)

        public int getPassMark()
        {
            return this._passmark;
        }

        //Only get is used in this method to avoid changing of Pass Mark

    }
}
