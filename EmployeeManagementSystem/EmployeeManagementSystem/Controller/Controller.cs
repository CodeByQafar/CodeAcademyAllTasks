

using EmployeeManagementSystem.Exceptions;
using EmployeeManagementSystem_Enums;
using EmployeeManagementSystem_Exceptions;
using EmployeeManagementSystem_Helpers;
using EmployeeManagementSystem_Models;
using EmployeeManagementSystem_Services;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Controller
{
    public static class Controller
    {

        public static void LoadFromFile()
        {
            EmployeeService.LoadFromFile();
        }
        public static void ShowMenu()
        {
            Helper.ConsolWriteLine(ConsoleColor.White,
                "Select Option\r\n\n" +
                "1. Add Employee\r\n" +
                "2. Remove Employee\r\n" +
                "3. Search Employee\r\n" +
                "4. Update Employee\r\n" +
                "5. List Employees\r\n" +
                "6. Sort Employees\r\n" +
                "7. Filter Employees\r\n" +
                "8. Clear Console\r\n" +
                "0. Exit\r\n"
                );
        }
        public static void AddEmployee()
        {
            int Id;
            string Name;
            Positon positionInput;
            decimal Salary;
            string Department;
            Contact WorkInfo;

            while (true)
            {
                Helper.ConsolWriteLine(ConsoleColor.Cyan, "Enter Id: ");
                if (int.TryParse(Console.ReadLine(), out Id) && Id >= 0)
                    break;

                Helper.ConsolWriteLine(ConsoleColor.Red, "Invalid Id. Please enter a valid positive integer.");
            }

            while (true)
            {
                Helper.ConsolWriteLine(ConsoleColor.Cyan, "Enter Name: ");
                Name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(Name))
                    break;

                Helper.ConsolWriteLine(ConsoleColor.Red, "Name cannot be empty.");
            }

            while (true)
            {
                Helper.ConsolWriteLine(ConsoleColor.Cyan, "Enter Position (Junior, Middle, Senior, Manager): ");

                try
                {
                    positionInput = PostionExtension.Parse(Console.ReadLine());
                    break;
                }
                catch (InvalidPostionException ex)
                {
                    Helper.ConsolWriteLine(ConsoleColor.Red, ex.Message);
                }
            }

            while (true)
            {
                Helper.ConsolWriteLine(ConsoleColor.Cyan, "Enter Salary: ");
                if (decimal.TryParse(Console.ReadLine(), out Salary) && Salary >= 0)
                    break;

                Helper.ConsolWriteLine(ConsoleColor.Red, "Invalid Salary. Please enter a valid positive number.");
            }

            while (true)
            {
                Helper.ConsolWriteLine(ConsoleColor.Cyan, "Enter Department: ");
                Department = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(Department))
                    break;

                Helper.ConsolWriteLine(ConsoleColor.Red, "Department cannot be empty.");
            }

            int officeNumber, floor;

            while (true)
            {
                Helper.ConsolWriteLine(ConsoleColor.Cyan, "Enter OfficeNumber:");
                if (int.TryParse(Console.ReadLine(), out officeNumber))
                    break;

                Helper.ConsolWriteLine(ConsoleColor.Red, "Invalid OfficeNumber. Please enter a valid integer.");
            }

            while (true)
            {
                Helper.ConsolWriteLine(ConsoleColor.Cyan, "Enter Floor:");
                if (int.TryParse(Console.ReadLine(), out floor))
                    break;

                Helper.ConsolWriteLine(ConsoleColor.Red, "Invalid Floor. Please enter a valid integer.");
            }

            try
            {
                WorkInfo = new Contact(officeNumber, floor);
                Employee newEmployee = new Employee(Id, Name, positionInput, Salary, Department, WorkInfo);

                EmployeeService.AddEmployee(newEmployee);

                Helper.ConsolWriteLine(ConsoleColor.Green, "Employee added successfully.");
            }
            catch (NameEmptyException ex)
            {
                Helper.ConsolWriteLine(ConsoleColor.Red, ex.Message);
            }
            catch (NameLengthException ex)
            {
                Helper.ConsolWriteLine(ConsoleColor.Red, ex.Message);
            }
            catch (InvalidPostionException ex)
            {
                Helper.ConsolWriteLine(ConsoleColor.Red, ex.Message);
            }
            catch (InvalidWorkInfoException ex)
            {
                Helper.ConsolWriteLine(ConsoleColor.Red, ex.Message);
            }
            catch (DuplicateEmployeeException ex)
            {
                Helper.ConsolWriteLine(ConsoleColor.Red, ex.Message);
            }
            catch (Exception ex)
            {
                Helper.ConsolWriteLine(ConsoleColor.Red, $"Unexpected error: {ex.Message}");
            }
        }
        public static void RemoveEmployee()
        {
            int Id;

            while (true)
            {
                Helper.ConsolWriteLine(ConsoleColor.Cyan, "Enter employye Id to remove: ");
                if (int.TryParse(Console.ReadLine(), out Id) && Id >= 0)
                    break;

                Helper.ConsolWriteLine(ConsoleColor.Red, "Invalid Id. Please enter a valid positive integer.");
            }
            try
            {
                EmployeeService.RemoveEmploye(Id);
                Helper.ConsolWriteLine(ConsoleColor.Green, "Employee removed successfully.");
            }
            catch (EmployeeNotFoundException ex)
            {
                Helper.ConsolWriteLine(ConsoleColor.Red, ex.Message);
            }
            catch (Exception ex)
            {
                Helper.ConsolWriteLine(ConsoleColor.Red, $"Unexpected error: {ex.Message}");
            }
        }

        public static void SearchEmployee()
        {
            int Id;

            while (true)
            {
                Helper.ConsolWriteLine(ConsoleColor.Cyan, "Enter employye Id to find: ");
                if (int.TryParse(Console.ReadLine(), out Id) && Id >= 0)
                    break;

                Helper.ConsolWriteLine(ConsoleColor.Red, "Invalid Id. Please enter a valid positive integer.");
            }
            try
            {
                Employee employee = EmployeeService.SearchEmployee(Id);
                employee.PrintInfo();
            }
            catch (EmployeeNotFoundException ex)
            {
                Helper.ConsolWriteLine(ConsoleColor.Red, ex.Message);
            }
            catch (Exception ex)
            {
                Helper.ConsolWriteLine(ConsoleColor.Red, $"Unexpected error: {ex.Message}");
            }
        }

        public static void UpdateEmployee()
        {
            int Id;
            string Name;
            Positon positionInput;
            decimal Salary;
            string Department;
            Contact WorkInfo;

            while (true)
            {
                Helper.ConsolWriteLine(ConsoleColor.Cyan, "Enter updated employye Id: ");
                if (int.TryParse(Console.ReadLine(), out Id) && Id >= 0)
                    break;

                Helper.ConsolWriteLine(ConsoleColor.Red, "Invalid Id. Please enter a valid positive integer.");
            }

            while (true)
            {
                Helper.ConsolWriteLine(ConsoleColor.Cyan, "Enter Name: ");
                Name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(Name))
                    break;

                Helper.ConsolWriteLine(ConsoleColor.Red, "Name cannot be empty.");
            }

            while (true)
            {
                Helper.ConsolWriteLine(ConsoleColor.Cyan, "Enter Position (Junior, Middle, Senior, Manager): ");

                try
                {
                    positionInput = PostionExtension.Parse(Console.ReadLine());
                    break;
                }
                catch (InvalidPostionException ex)
                {
                    Helper.ConsolWriteLine(ConsoleColor.Red, ex.Message);
                }
            }

            while (true)
            {
                Helper.ConsolWriteLine(ConsoleColor.Cyan, "Enter Salary: ");
                if (decimal.TryParse(Console.ReadLine(), out Salary) && Salary >= 0)
                    break;

                Helper.ConsolWriteLine(ConsoleColor.Red, "Invalid Salary. Please enter a valid positive number.");
            }

            while (true)
            {
                Helper.ConsolWriteLine(ConsoleColor.Cyan, "Enter Department: ");
                Department = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(Department))
                    break;

                Helper.ConsolWriteLine(ConsoleColor.Red, "Department cannot be empty.");
            }

            int officeNumber, floor;

            while (true)
            {
                Helper.ConsolWriteLine(ConsoleColor.Cyan, "Enter OfficeNumber:");
                if (int.TryParse(Console.ReadLine(), out officeNumber))
                    break;

                Helper.ConsolWriteLine(ConsoleColor.Red, "Invalid OfficeNumber. Please enter a valid integer.");
            }

            while (true)
            {
                Helper.ConsolWriteLine(ConsoleColor.Cyan, "Enter Floor:");
                if (int.TryParse(Console.ReadLine(), out floor))
                    break;

                Helper.ConsolWriteLine(ConsoleColor.Red, "Invalid Floor. Please enter a valid integer.");
            }

            try
            {
                WorkInfo = new Contact(officeNumber, floor);
                Employee newEmployee = new Employee(Id, Name, positionInput, Salary, Department, WorkInfo);

                EmployeeService.UpdateEmployee(newEmployee);

                Helper.ConsolWriteLine(ConsoleColor.Green, "Employee added successfully.");
            }
            catch (NameEmptyException ex)
            {
                Helper.ConsolWriteLine(ConsoleColor.Red, ex.Message);
            }
            catch (NameLengthException ex)
            {
                Helper.ConsolWriteLine(ConsoleColor.Red, ex.Message);
            }
            catch (InvalidPostionException ex)
            {
                Helper.ConsolWriteLine(ConsoleColor.Red, ex.Message);
            }
            catch (InvalidWorkInfoException ex)
            {
                Helper.ConsolWriteLine(ConsoleColor.Red, ex.Message);
            }
            catch (DuplicateEmployeeException ex)
            {
                Helper.ConsolWriteLine(ConsoleColor.Red, ex.Message);
            }
            catch (EmployeeNotFoundException ex)
            {
                Helper.ConsolWriteLine(ConsoleColor.Red, ex.Message);
            }
            catch (Exception ex)
            {
                Helper.ConsolWriteLine(ConsoleColor.Red, $"Unexpected error: {ex.Message}");
            }
        }

        public static void ListEmployees()
        {
            EmployeeService.ListEmployees();
        }

        public static void SortEmployees()
        {
        sortOption: try
            {
                Helper.ConsolWriteLine(ConsoleColor.Cyan,
                               "Select Sort Option:\r\n\n" +
                               "1. By Id\r\n" +
                               "2. By Name\r\n" +
                               "3. By HireDate\r\n" +
                               "4. By Salary\r\n"
                               );

                SortOption sortOption = SortOptionExtension.Parse(Console.ReadLine());
                EmployeeService.SortEmployees(sortOption);
              

            }
            catch (InvalidSortByOptionException ex)
            {
                Helper.ConsolWriteLine(ConsoleColor.Red, $"Unexpected error: {ex.Message}");
                goto sortOption;
            }
        }

        public static void FilterEmployees()
        {
            Helper.ConsolWriteLine(ConsoleColor.Cyan, "enter name or sallary to filter:");
          option:  string option = Console.ReadLine();

            if (option.ToLower() == "name")
            {
                Helper.ConsolWriteLine(ConsoleColor.Cyan, "enter name:");
                string name = Console.ReadLine();
                EmployeeService.FilterEmployees(name);
            }
            else if (option.ToLower() == "sallary")
            {
            minSallary: Helper.ConsolWriteLine(ConsoleColor.Cyan, "enter min sallary:");
                int minSallary;
                bool isMinSallary = int.TryParse(Console.ReadLine(), out minSallary);
                if (!isMinSallary)
                {
                    Helper.ConsolWriteLine(ConsoleColor.Red, "invalid min sallary");
                    goto minSallary;
                }
            maxSallary: Helper.ConsolWriteLine(ConsoleColor.Cyan, "enter max sallary:");
                int maxSallary;
                bool isMaxSallary = int.TryParse(Console.ReadLine(), out maxSallary);
                if (!isMaxSallary)
                {
                    Helper.ConsolWriteLine(ConsoleColor.Red, "invalid min sallary");
                    goto minSallary;
                }

             
                    EmployeeService.FilterEmployees(maxSallary, minSallary);

            }
            else
            {
                Helper.ConsolWriteLine(ConsoleColor.Red, "enter name or sallary option");
                goto option;
            }
        }

        public static void ClearConsole()
        {
            Console.Clear();
            ShowMenu();
        }
    }
}
