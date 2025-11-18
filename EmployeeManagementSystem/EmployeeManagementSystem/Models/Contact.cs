using EmployeeManagementSystem_Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public struct Contact
    {
        int? OfficeNumber;
        int Floor;
        public Contact(int? officeNumber, int floor)
        {
            if (officeNumber == null)
            {
                throw new InvalidWorkInfoException("office number can't be null");
            }
            else
            {
                OfficeNumber = officeNumber;
            }
            if (floor < 0)
            {
                throw new InvalidWorkInfoException("floor must be higher than 0");
            }
            else
            {
                Floor = floor;
            }
        }
    }
}
