using System;
using System.Runtime.Serialization;
namespace ClassLibraryRentService
{
    [Serializable]
 
    public class InvalidRentedCarException : System.Exception
    {
        public InvalidRentedCarException()
        {
        }

        public InvalidRentedCarException(string message) : base(message)
        {
        }

        public InvalidRentedCarException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidRentedCarException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }

}
