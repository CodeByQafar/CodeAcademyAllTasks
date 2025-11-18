using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem_Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeManagementSystem.Models
{
    public class Employee : Person, IPrintable
    {
        Positon Postion;
        DateTime HireDate;
        decimal Salary;
        string Department;
        Contact WorkInfo;
        public Employee(int id, string name, Positon postion, decimal salary, string department, Contact workInfo) : base(id, name)
        {
            Postion = postion;
            HireDate = DateTime.Now;
            Salary = salary;
            Department = department;
            WorkInfo = workInfo;
        }
        public void PrintInfo()
        {
            Helper.ConsolWriteLine(ConsoleColor.DarkGreen, $"\n" +
                         $"Employee Information:\n" +
                         $"-----------------------\n" +
                         $"ID: {Id}\n" +
                         $"Name: {Name}\n" +
                         $"Position: {Postion}\n" +
                         $"Salary: {Salary:C} \n" +
                         $"Department: {Department}\n" +
                         $"Contact: {WorkInfo}");
        }
    }
}
