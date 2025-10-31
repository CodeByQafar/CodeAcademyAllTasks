using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._30._2025.Exceptions
{
     class InvalidNoException:Exception
    {
        public InvalidNoException(string message) : base(message)
        {

        }
    }
}
