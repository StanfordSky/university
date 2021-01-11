using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace ClassLibraryRentService
{

    [Serializable]
    public class InvalidClientException : System.Exception
    {
        public InvalidClientException()
        {
        }

        public InvalidClientException(string message) : base(message)
        {
        }

        public InvalidClientException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidClientException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }

}
