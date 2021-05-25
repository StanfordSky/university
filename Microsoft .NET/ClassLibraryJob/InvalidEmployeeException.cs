using System;
using System.Runtime.Serialization;

namespace ClassLibraryWork.Exception
{
    [Serializable]
    public class InvalidEmployeeException : System.Exception
    {
        public InvalidEmployeeException()
        {

        }

        public InvalidEmployeeException(string message) : base(message)
        {

        }

        public InvalidEmployeeException(string message, System.Exception inner) : base(message, inner)
        {

        }

        protected InvalidEmployeeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
