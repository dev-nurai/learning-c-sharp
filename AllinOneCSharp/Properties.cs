using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        //Proctecting Class fields using Setter and Getter Method.

        //Student Id cannot be negative so use the below conditions

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


        //Getting rid of Setter and Getter Method

        //Set is used to Write the Property/Method
        //Get is used to Read the Property/Method;


        //Using Property to protect the Class field.

        //For Id
        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student Id cannot be Zero or Negative");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

        //For Name
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this._name = value;
            }

            get
            {
                return string.IsNullOrEmpty(this._name) ? "No Name Mentioned" : this._name;
            }
        }

        //For PassMark

        public int passMark
        {
            get
            {
                return this._passmark;
            }
        }

        //Auto Implemented Properties

        //If the Properties do not have any logic or just need to assign the value then use Auto Implemented Properties
        //In Auto Implemented Properties, we dont need to assign Class-Field (private).


        //Example

        public string Email { get; set; }

        public string City { get; set; }

        //public string Email
        //{
        //    set
        //    {
        //        this.Email = value;
        //    }
        //    get
        //    {
        //        return this.Email;
        //    }
        //}

        //public string City
        //{
        //    get
        //    {
        //        return this.City;
        //    }
        //    set
        //    {
        //        this.City = value;
        //    }
        //}


    }
}
