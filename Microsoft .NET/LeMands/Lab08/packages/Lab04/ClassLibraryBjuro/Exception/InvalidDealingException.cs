using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ClassLibraryBjuro.Exception
{

    [Serializable]
    public class InvalidDealingException : System.Exception
    {
        public InvalidDealingException()
        {
        }

        public InvalidDealingException(string message) : base(message)
        {
        }

        public InvalidDealingException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidDealingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
