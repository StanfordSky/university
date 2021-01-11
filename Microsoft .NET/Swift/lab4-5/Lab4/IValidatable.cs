using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryRentService
{
    interface IValidatable
    {
        bool IsValid { get; }
    }
}
