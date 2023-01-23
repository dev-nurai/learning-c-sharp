using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    public abstract class AbstractvsInterface //Can inheritance with Abstract Class or Interface Class
    {
        public int Number; //Fields are allowed in Abstract Class
        public string Name = "Gufran";
        public void PrintAbstract() //Implementations are allowed with non-abstract class (withinn Abstract Class).
        {
            Console.WriteLine("Print of class in within Abstract Class");
        }
    }

    public interface IInterface //Interface Class will only inheritance will another Interface class [not others]
    {
        //Fields are not allowed in Abstract Class
        void PrintInterface(); //Cannot have implementation
    }

}


/*
 Abstract class members can have access modifiers where as Interface members cannot have access modifiers.
 */