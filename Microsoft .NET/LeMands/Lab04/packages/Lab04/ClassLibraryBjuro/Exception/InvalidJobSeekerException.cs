using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ClassLibraryBjuro.Exception
{

    [Serializable]
    class InvalidJobSeekerException : System.Exception
    {
        public InvalidJobSeekerException()
        {
        }

        public InvalidJobSeekerException(string message) : base(message)
        {
        }

        public InvalidJobSeekerException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidJobSeekerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
