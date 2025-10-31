
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._30._2025.Models.task2
{
    internal class Group
    {
        string no;
        Student[] students;
        int StudentLimit;

        public Group(string no, Student[] students, int StudentLimit)
        {
            if (noChecker(no))
            {
                this.no = no;
            }
            else
            {
                throw new Exception();
            }

            this.students = students;
            this.StudentLimit = StudentLimit;
        }

        public void AddStudent(Student student)
        {
            if (students.Length < StudentLimit)
            {
                Student[] res = new Student[students.Length];
                for (int i = 0; i < students.Length; i++)
                {
                    res[i] = students[i];
                }
                res[students.Length] = student;
                students = res;
            }
            else
            {
                Console.WriteLine("you reache max student limit");
            }
        }
        public bool noChecker(string no)
        {
            if (this.no.Substring(0, 2).All(char.IsUpper) && this.no.Substring(2).All(char.IsDigit) && this.no.Length == 5)
            {
                return true;
            }
            return false;
        }
    }
}
