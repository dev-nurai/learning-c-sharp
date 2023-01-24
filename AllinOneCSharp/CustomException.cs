using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace AllinOneCSharp
{

    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        //This will work within this application domain only.

        //Constructor for UserAlreadyLoggedInException with no Parameters;
        public UserAlreadyLoggedInException() : base() //inheriting from the base Exception class
        { 

        }
        //Constructor for UserAlreadyLoggedInException with (message) Parameters;
        public UserAlreadyLoggedInException(string message) : base(message)
        {

        }

        //Original Exception
        public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)
        {

        }

        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }

    }
}
