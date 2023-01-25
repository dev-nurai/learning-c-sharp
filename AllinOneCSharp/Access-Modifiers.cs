using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOneCSharp
{
    internal class Access_Modifiers
    {
    }

    public class Voter //Type
    {
        //Type Members
        private int _id; //Private Access-Modifier

        //Private access field can only accessible in this "Type" Class only.

        public int Id { get { return _id; } set { _id = value;} } //Public Access-Modifier

        //Public access field can accessible anywhere. No restrictions.

        protected string _name;

        //Procted access field can accessible in this "Type" Class and any derived Class from the base Class.
    }

    public class UrbanVoter : Voter
    {
        public void PrintName()
        {
            //Protected Access modifiers are used here using base Class inheritance.

            UrbanVoter urbanvoter = new UrbanVoter();
            urbanvoter._name = "Karn";

            //Below both can be used to define the values directly without instance.

            //base._name = "Faisal";
            //this._name = "Raja";
        }

    }
    /*
    //Internal Access-Modifier

    Can be used anywhere in the Assembly, Means can be used in Same Project to any Class.
        Assembly - Project that are roof under one solution.
        Project are two type [file]
            - exe
            - dll
          
    //Protected Internal Access-Modifier
        Can be used anywhere in the Assembly and any derived Assembly from the base Assembly.
        Protected + Internal.


    */

}

/*
    Types and Types Members
        (Customer, Voter) Class, Structs, Enums, Interface, Delegates are called as "Type" and fields, Properties, Constructor and Methods
        are called as "Type Members".
    
    Access Modifiers in C#
        Public
        Private
        Protected
        Internal
        Protected Internal

    Note: "Type Members" can have all 5 Access-Modifiers, where as "Type" can have only 2 Access-Modifiers (Internal & Public)
    
    In Type, Default Access Modifier will be "Internal" and In Type Members, Default Access Modifier will be "Private".
 */
