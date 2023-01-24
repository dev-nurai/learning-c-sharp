using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    public class Client
    {
        //Default underlying type is "int" and value starts from Zero.
        public enum Gender : short //Short is used to save memory space.
        {
            Unknow, // = 0,
            Male, // = 1,
            Female // = 2
        }
        //Enums values need not be in sequential order Any valid underlying type value is allowed
        /*
         {  Unknown = 1
            Male = 44,
            Female = 99
         }

         
         */
        public enum Season
        {
            Winter,
            Summer,
            Rainy
        }

        //0 - Unknown
        //1 - Male
        //2 - Female
        public string Name { get; set; }
        public Gender gender { get; set; }

    }
}

//Enums are strongly typed constants.

/*
If program uses set of integral numbers, consider replacing them with "Enums", which makes Program more
    Readable [code]
    Maintainable

*/