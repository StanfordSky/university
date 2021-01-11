using System;
using System.Runtime.Serialization;


namespace ClassLibraryRentService
{
  
    [Serializable]
    public class InvalidCarException : System.Exception
    {
        public InvalidCarException()
        {
        }

        public InvalidCarException(string message) : base(message)
        {
        }

        public InvalidCarException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidCarException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }

}
