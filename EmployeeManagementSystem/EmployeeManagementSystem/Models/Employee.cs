
using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem_Enums;
using EmployeeManagementSystem_Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeManagementSystem_Models
{
    public class Employee : Person, IPrintable
    {
        public Positon Postion { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public Contact WorkInfo { get; set; }
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
            Helper.ConsolWriteLine(ConsoleColor.DarkGreen,
                         $"\n" +
                         $"ID: {Id}\n" +
                         $"Name: {Name}\n" +
                         $"Position: {Postion}\n" +
                         $"Salary: {Salary:C} \n" +
                         $"Department: {Department}\n" +
                         $"Contact: {WorkInfo}\n" +
                         $"HireDate: {HireDate}\n"
                         );
        }
    }
}
