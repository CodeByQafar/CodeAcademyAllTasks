using ClassTask11._07._2025.Models;
using ClassTask11._07._2025.task_2.Models;
using ClassTask11._07._2025.task_3.Enums;
using ClassTask11._07._2025.task_3.Models;

namespace MyApp
{
    class Program
    {
        static void Main()
        {
            List<Book> books = new List<Book>()
            {
                new Book("The Great Gatsby", 25, 10, 0, "F. Scott Fitzgerald", 180),
                new Book("To Kill a Mockingbird", 30, 8, 0, "Harper Lee", 281),
                new Book("1984", 28, 5, 0, "George Orwell", 328),
                new Book("Pride and Prejudice", 22, 12, 0, "Jane Austen", 279),
                new Book("The Hobbit", 35, 6, 0, "J.R.R. Tolkien", 310),
            };

            books[2].ShowInfo();
            books[3].ShowInfo();

            books[2].Sell();
            books[2].ShowInfo();









            Employee emp1 = new Employee("Ali", "Huseynov", 25, 1200, "ali@example.com");
            Employee emp2 = new Employee("Aysel", "Mammadova", 28, 1500, "aysel@example.com");
            Employee emp3 = new Employee("Murad", "Aliyev", 30, 1800, "murad@example.com");

            Department<Employee> department = new Department<Employee>(5, new List<Employee>());

            try
            {
                department.AddEmployee(emp1);
                department.AddEmployee(emp2);
                department.AddEmployee(emp3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("All Employees:");
            foreach (var emp in department.GetAllEmployees())
            {
                emp.ShowInfo();
            }

            Console.WriteLine("Employees with Salary between 1300 and 1900:");
            var filtered = department.FilterEmployeesBySalary(1300, 1900);
            foreach (var emp in filtered)
            {
                emp.ShowInfo();
            }


            try
            {
                Console.WriteLine("Get Employee by Id 2:");
                var e = department.GetEmployeeById(2);
                e.ShowInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                Console.WriteLine("Deleting Employee with Id 1");
                department.DeleteEmployeeById(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("Employees after deletion:");
            foreach (var emp in department.GetAllEmployees())
            {
                emp.ShowInfo();
            }












            CurrencyConverter converter = new CurrencyConverter();

            double aznAmount = 2;
            double usdAmount = converter.Exchange(Currency.USD, aznAmount);

            Console.WriteLine(usdAmount);
        }

    }

}