using EmployeeManagementSystem_Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem_Models
{
    public struct Contact
    {
        public int OfficeNumber { get; set; }
        public int Floor { get; set; }
        public Contact(int officeNumber, int floor)
        {
            if (officeNumber == null)
                throw new InvalidWorkInfoException("office number can't be null");

            if (floor < 0)
                throw new InvalidWorkInfoException("floor must be higher than 0");

            OfficeNumber = officeNumber;
            Floor = floor;
        }
        public override string ToString()
        {
            return $"Office: {OfficeNumber}, Floor: {Floor}";
        }
    }
}
