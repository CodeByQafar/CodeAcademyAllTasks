using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._07._2025.Exceptions
{
    internal class ProductCountIsZeroException : Exception
    {

        public ProductCountIsZeroException(string message) : base(message) { }
    }
}
