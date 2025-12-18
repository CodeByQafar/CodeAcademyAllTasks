using ClassTask11._07._2025.task_2.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._07._2025.task_2.Models
{
    class Department<T> where T : Employee
    {
        public int EmployeeLimit;

        public List<T> Employees;

        public Department(int EmployeeLimit, List<T> Employees)
        {
            this.EmployeeLimit = EmployeeLimit;
            this.Employees = Employees;
        }

        public Func<T, List<T>, bool> IsExistsEmployee = (employee, employees) =>
        {
            foreach (T item in employees)
            {
                if (item == employee)
                {
                    return true;
                }
            }
            return false;
        };


        public void AddEmployee(T employee)
        {
            if (IsExistsEmployee(employee, Employees))
            {
                throw new EmployeeAlreadyExistsException(" Employee Already Exists");
            }
            else if (EmployeeLimit < Employees.Count)
            {
                throw new CapacityLimitException("Capacity Limit Exception");
            }
            Employees.Add(employee);
        }


        public List<T> GetAllEmployees()
        {
            return Employees;
        }

        public List<T> FilterEmployeesBySalary(int minSalary, int maxSalary)
        {
            List<T> res = new List<T>();
            foreach (T item in Employees)
            {
                if (item.Salary > minSalary && item.Salary < maxSalary)
                {
                    res.Add(item);
                }
            }

            return res;
        }

        public T GetEmployeeById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException("Null Reference Exception");
            }

            foreach (T item in Employees)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            throw new NotFoundException("employee not Found exception");
        }

        public T DeleteEmployeeById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException("Null Reference Exception");
            }

            foreach (T item in Employees)
            {
                if (item.Id == id)
                {
                    Employees.Remove(item);
                }
            }
            throw new NotFoundException("employee not Found exception");
        }


        public void DeleteEmployeeById(int? id,string? email)
        {
            if (id == null||email==null)
            {
                throw new NullReferenceException("Null Reference Exception");
            }
            for (int i=0;i>Employees.Count;i++)
            {
                if (Employees[i].Id == id)
                {
                    Employees[i].Email=email;
                    return;
                }
            }
            throw new NotFoundException("employee not Found exception");
        }
  
    }
}
