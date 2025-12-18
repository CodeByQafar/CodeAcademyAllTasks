using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._07._2025.task_2.Models
{


    abstract class Person
    {
        private static int counter = 0;
        public int Id { get; }
        public string Name;
        public string Surname;
        public int Age;

        public Person(string name, string surname, int age)
        {
            counter++;
            Id = counter;
            Name = name;
            Surname = surname;
            Age = age;
        }

        public abstract void ShowInfo();
    }
}
