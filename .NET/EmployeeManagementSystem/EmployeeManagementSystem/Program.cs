using EmployeeManagementSystem.Controller;
using EmployeeManagementSystem_Enums;
using EmployeeManagementSystem_Helpers;
using EmployeeManagementSystem_Models;
using EmployeeManagementSystem_Services;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller.LoadFromFile();
            Controller.ShowMenu();
            try {
                option:
                int option;
                
               bool isOption =int.TryParse(Console.ReadLine(), out option);
                if(isOption)
                {
                    switch (option)
                    {
                        case 1:
                            Controller.AddEmployee();
                            goto option;
                            break;
                        case 2:
                            Controller.RemoveEmployee();
                            goto option;
                            break;
                        case 3:
                            Controller.SearchEmployee();
                            goto option;
                            break;
                        case 4:
                            Controller.UpdateEmployee();
                            goto option;
                            break;
                        case 5:
                            Controller.ListEmployees();
                            goto option;
                            break;
                        case 6:
                            Controller.SortEmployees();
                            goto option;
                            break;
                        case 7:
                            Controller.FilterEmployees();
                            goto option;
                            break;
                        case 8:
                            Controller.ClearConsole();
                            goto option;
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                        default:
                            Helper.ConsolWriteLine(ConsoleColor.Red, "Invalid option. Please select a valid option.");
                            goto option;
                            break;
                    }
                }
                else
                {
                    Helper.ConsolWriteLine(ConsoleColor.Red, "Invalid input. Please enter a number corresponding to the menu options.");
                    goto option;


                }
            } catch (Exception ex)
            {

            }
        }
    }
}
