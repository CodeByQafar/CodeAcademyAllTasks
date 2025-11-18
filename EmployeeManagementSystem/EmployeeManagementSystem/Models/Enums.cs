using EmployeeManagementSystem.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public enum Positon
    {
        Junior, Middle, Senior, Manager
    }

    public static class PostionExtension
    {
        public static Positon Parse(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new InvalidPostionException("Position can't be null.");

            value = value.Trim().ToLower();

            if (value == "junior") return Positon.Junior;
            if (value == "middle") return Positon.Middle;
            if (value == "senior") return Positon.Senior;
            if (value == "manager") return Positon.Manager;
     

            throw new InvalidPostionException("Invalid postion , please enter junior middle senior or manger");
        }
    }
}

