using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
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
}
