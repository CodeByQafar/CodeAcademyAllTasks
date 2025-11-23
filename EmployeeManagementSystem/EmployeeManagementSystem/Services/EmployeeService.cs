using EmployeeManagementSystem_Enums;
using EmployeeManagementSystem_Exceptions;
using EmployeeManagementSystem_Helpers;
using EmployeeManagementSystem_Models;
using Newtonsoft.Json;
using System.IO;

namespace EmployeeManagementSystem_Services
{
  public static class EmployeeService
    {
    private static string jsonPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)
                                        .Parent.Parent.Parent.FullName, "Data", "employyes.json");
  
        public static List<Employee> Employees = new List<Employee>();

        public static void AddEmployee(Employee employee)
        {
            if (Employees.Exists(e => e.Id == employee.Id))
            {
                throw new DuplicateEmployeeException("This id used in another employee ");
            }
            Employees.Add(employee);
            SaveToFile();
        }
        public static void RemoveEmploye(int id)
        {
            Employee employee = SearchEmployee(id);
            Employees.Remove(employee);
            SaveToFile();
        }
        public static Employee SearchEmployee(int id)
        {
            Employee? employee = Employees.Find(e => e.Id == id);
            if (employee == null)
            {
                throw new EmployeeNotFoundException("this id employee not finded");
            }
            return employee;
        }
        public static void UpdateEmployee(Employee newEmployee)
        {
            int employeeIndex = Employees.IndexOf(SearchEmployee(newEmployee.Id));
            Employees[employeeIndex] = newEmployee;
        }
        public static void ListEmployees()
        {

            if (Employees.Count == 0)
            {
                Helper.ConsolWriteLine(ConsoleColor.Yellow, "You don't have any empployee");
            }
            else
            {
                foreach (Employee employee in Employees)
                {
                    employee.PrintInfo();
                }
            }
        }
        public static void SortEmployees(SortOption option)
        {
            if (option == SortOption.ID)
                Employees.Sort((x, y) => x.Id.CompareTo(y.Id));

            if (option == SortOption.Name)
                Employees.Sort((x, y) => x.Name.CompareTo(y.Name));

            if (option == SortOption.HireDate)
                Employees.Sort((x, y) => x.HireDate.CompareTo(y.HireDate));

            if (option == SortOption.Salary)
                Employees.Sort((x, y) => x.Salary.CompareTo(y.Salary));

            Helper.ConsolWriteLine(ConsoleColor.Blue, $"Sorted by {option.ToString()}");
            ListEmployees();


        }
        public static void FilterEmployees(string name)
        {
            List<Employee> employees = new List<Employee>();

            employees = Employees.FindAll(employee => employee.Name == name);

            if (employees.Count == 0)
            {
                Helper.ConsolWriteLine(ConsoleColor.Yellow, "You don't have any empployee for this filter");
            }
            else
            {
                foreach (Employee employee in employees)
                {
                    employee.PrintInfo();
                }
            }
        }
        public static void FilterEmployees(int maxSallary, int minSallary)
        {
            List<Employee> employees = new List<Employee>();

            employees= Employees.FindAll(employee => employee.Salary > minSallary && employee.Salary < maxSallary);

            if (employees.Count == 0)
            {
                Helper.ConsolWriteLine(ConsoleColor.Yellow, "You don't have any empployee for this filter");
            }
            else
            {
                foreach (Employee employee in employees)
                {
                    employee.PrintInfo();
                }
            }
        }
        public static void SaveToFile() {
            string json = JsonConvert.SerializeObject(Employees, Formatting.Indented);
            File.WriteAllText(jsonPath, json);
        }
        public static void LoadFromFile() {
            if (!File.Exists(jsonPath))
            {
                throw new FileNotFoundException("JSON file not found.");
            }

            string json = File.ReadAllText(jsonPath);

            List<Employee>? loaded = JsonConvert.DeserializeObject<List<Employee>>(json);

            if (loaded == null)
            {
                Helper.ConsolWriteLine(ConsoleColor.Red, "Failed to load employees from JSON.");
                return;
            }

            Employees = loaded;

            Helper.ConsolWriteLine(ConsoleColor.Green, "Employees loaded from employees.json");

        }

    }
}
