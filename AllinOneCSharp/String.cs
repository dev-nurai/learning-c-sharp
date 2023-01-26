using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    internal class String
    {
    }
    public class Billionaire
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        // if we convert string to string using toString, Console will print "AllinOneCharp.Billionaire.

        //Use the below overide method
        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }

        //toSting() vs Convert.ToString()

        public class Movie
        {
            public string movieName { get; set; }
        }

        //System.String vs String builder



        /*
         Sytem.String is immutable. On every String manipulation, String data will store a new. Will create multiple space for single.
            will work on System; directory

        StringBuilder is immutable. Only one space will be created in heap for all String Manipulation. 
            will work on System.Text; directory
            they offer better performance than string objects when heavy string manipulation is involved.
         
         */


    }
}

/*
    //toSting() vs Convert.ToString()
        Convert.ToString() handles null, while toString() doesn't, and throws a Null Reference Exception.

 */