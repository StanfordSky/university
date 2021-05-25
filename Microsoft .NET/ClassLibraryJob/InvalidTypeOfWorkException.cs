using System;
using System.Runtime.Serialization;

namespace ClassLibraryWork.Exception
{
    [Serializable]
    public class InvalidTypeOfWorkException : System.Exception
    {
        public InvalidTypeOfWorkException()
        {

        }

        public InvalidTypeOfWorkException(string message) : base(message)
        {

        }

        public InvalidTypeOfWorkException(string message, System.Exception inner) : base(message, inner)
        {

        }

        protected InvalidTypeOfWorkException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
