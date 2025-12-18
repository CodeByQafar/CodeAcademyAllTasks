using StudentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._06._2025.models
{
    internal class StudentManager<T> where T : Student
    {
        public List<T> students= new List<T>();
        public void addStudent(T student) { 
        students.Add(student);
        }
    }
}
