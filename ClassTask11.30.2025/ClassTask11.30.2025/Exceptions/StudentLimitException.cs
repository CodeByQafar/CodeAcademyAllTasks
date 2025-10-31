using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._30._2025.Exceptions
{
     class StudentLimitException :Exception
    {
        public StudentLimitException(string message) : base(message)
        {

        }
    }
}
