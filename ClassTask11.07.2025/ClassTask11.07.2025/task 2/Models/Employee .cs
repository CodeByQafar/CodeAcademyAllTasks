using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassTask11._07._2025.task_2.Models
{
    class Employee : Person
    {

        public int Salary;
        public string Email;
        public Employee( string name, string surname, int age, int salary, string email) : base( name, surname, age)
        {
            Salary = salary;
            Email = email;

        }

        public override void ShowInfo()
        {
            Console.WriteLine(
        $"Id: {Id}\n" +
        $"Name: {Name}\n" +
        $"Surname: {Surname}\n" +
        $"Age: {Age}\n" +
        $"Salary: {Salary}\n" +
        $"Email: {Email}\n"
                );
        }

        public static bool operator ==(Employee p1, Employee p2)
        {
            if (ReferenceEquals(p1, p2))
                return true;
            if (p1 is null || p2 is null)
                return false;

            return p1.Id == p2.Id &&
       p1.Name == p2.Name &&
       p1.Surname == p2.Surname &&
       p1.Age == p2.Age &&
       p1.Salary == p2.Salary &&
       p1.Email == p2.Email;
        }

        public static bool operator !=(Employee p1, Employee p2)
        {
            return !(p1 == p2);
        }
    }
}
