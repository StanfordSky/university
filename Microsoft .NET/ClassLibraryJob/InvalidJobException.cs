using System;
using System.Runtime.Serialization;

namespace ClassLibraryWork.Exception
{
    [Serializable]
    public class InvalidJobException : System.Exception
    {
        public InvalidJobException()
        {

        }

        public InvalidJobException(string message) : base(message)
        {

        }

        public InvalidJobException(string message, System.Exception inner) : base(message, inner)
        {

        }

        protected InvalidJobException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
