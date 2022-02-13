using System;
using System.Collections.Generic;
using System.Text;

namespace Vulpes.Core.Exceptions
{
    class VuException : Exception
    {
        public VuException(string message) : base(message)
        {
        }
    }
}
