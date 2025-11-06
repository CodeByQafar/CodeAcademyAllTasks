using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._06._2025.Exceptions
{
    internal class intParseException:Exception
    {
        public intParseException(string message) : base(message) { }
    }
}
