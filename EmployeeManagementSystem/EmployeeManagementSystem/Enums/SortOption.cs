using EmployeeManagementSystem.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem_Enums
{
   public  enum SortOption
    {
        ID, Name, HireDate, Salary
    }

    public static class SortOptionExtension
    {
        public static SortOption Parse(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new InvalidPostionException("Position can't be null.");

            value = value.Trim().ToLower();

            if (value == "1") return SortOption.ID;
            if (value == "2") return SortOption.Name;
            if (value == "3") return SortOption.HireDate;
            if (value == "4") return SortOption.Salary;


            throw new InvalidSortByOptionException("Invalid Sort option, please enter 1:id 2:name 3:hiredate or 4:salary");
        }
    }
}
