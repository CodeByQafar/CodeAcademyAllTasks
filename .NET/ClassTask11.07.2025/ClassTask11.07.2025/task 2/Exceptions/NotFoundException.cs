using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._07._2025.task_2.Exceptions
{
    internal class NotFoundException:Exception
    {
        public NotFoundException(string message) : base(message) { }

    }
}
