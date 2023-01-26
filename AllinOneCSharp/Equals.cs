using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    internal class Equals
    {
    }
    public enum Direction
    {
        East = 1,
        West = 2,
        North = 3,
        South = 4
    }

    public class Traveller //
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public override bool Equals(object? obj)
        {
            if(obj == null)
            {
                return false;
            }
            if(!(obj is Traveller)) //Checking the users is traveller or not.
            {
                return false;
            }
            return this.firstName == ((Traveller)obj).firstName && this.lastName == ((Traveller)obj).lastName;

        }
        public override int GetHashCode() //Also over ride GetHashCode along with Equals
        {
            return this.firstName.GetHashCode() ^ this.lastName.GetHashCode();
        }
    }
}

/*
 Equals
    "==" will compare reference
    "Equals" will compare values,
 
 */