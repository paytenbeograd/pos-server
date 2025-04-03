using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosServer.Application.Exceptions
{
    public class EcrException : Exception
    {
        public EcrException(string message)
            : base(message) { }
    }
}
