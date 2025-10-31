
using ClassTask11._30._2025.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._30._2025.Models.task2
{
    internal class Groupp
    {
       public string no;
       public Student[] students;
       public int StudentLimit;

        public Groupp(string no, Student[] students, int StudentLimit)
        {
            if (noChecker(no))
            {
                this.no = no;
            }
            else
            {
                throw new InvalidNoException("Invalid no name");
            }

            this.students = students;
            this.StudentLimit = StudentLimit;
        }

        public void AddStudent(Student student)
        {
            if (students.Length < StudentLimit)
            {
                Student[] res = new Student[students.Length+1];
                for (int i = 0; i < students.Length; i++)
                {
                    res[i] = students[i];
                }
                res[students.Length] = student;
                students = res;
            }
            else
            {
                throw new StudentLimitException("you reached max student limit");
            }
        }
        public bool noChecker(string No)
        {
            if (No.Substring(0, 2).All(char.IsUpper) && No.Substring(2).All(char.IsDigit) && No.Length == 5)
            {
                return true;
            }
            return false;
        }
    }
}
