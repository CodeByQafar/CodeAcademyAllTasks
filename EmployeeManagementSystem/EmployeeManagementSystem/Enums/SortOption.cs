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

    public static class SortByOptionExtension
    {
        public static SortOption Parse(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new InvalidPostionException("Position can't be null.");

            value = value.Trim().ToLower();

            if (value == "id") return SortOption.ID;
            if (value == "name") return SortOption.Name;
            if (value == "hiredate") return SortOption.HireDate;
            if (value == "salary") return SortOption.Salary;


            throw new InvalidSortByOptionException("Invalid Sort option , please enter junior middle senior or manger");
        }
    }
}
