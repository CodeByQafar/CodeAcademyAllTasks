using EmployeeManagementSystem.Models;
using EmployeeManagementSystem_Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Services
{



    public static class EmployeeService
    {
        public static List<Employee> Employeers = new List<Employee>();

        public static void AddEmployee(Employee employee)
        {
            Employeers.Add(employee);
        }
        public static void RemoveEmploye(int id)
        {
            Employeers.Remove(SearchEmployee(id));
        }
        public static Employee? SearchEmployee(int id)
        {
            Employee? employee = Employeers.Find(e => e.Id == id);
            if (employee == null)
            {
                throw new EmployeeNotFoundException("thie id employee not finded");
            }
            return employee;
        }
        public static void UpdateEmployee() { }
        public static void ListEmployees() { }
        public static void SortEmployees() { }
        public static void FilterEmployees() { }
        public static void SaveToFile() { }
        public static void LoadFromFile() { }

    }
}
