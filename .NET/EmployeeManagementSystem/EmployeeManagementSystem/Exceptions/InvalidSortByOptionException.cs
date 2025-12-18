using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Exceptions
{
    public class InvalidSortByOptionException:Exception
    {

        public InvalidSortByOptionException(string message):base(message) { }
    }
}
