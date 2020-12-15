using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ClassLibraryBjuro.Exception
{

    [Serializable]
    class InvalidEmployerException : System.Exception
    {
        public InvalidEmployerException()
        {
        }

        public InvalidEmployerException(string message) : base(message)
        {
        }

        public InvalidEmployerException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidEmployerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
