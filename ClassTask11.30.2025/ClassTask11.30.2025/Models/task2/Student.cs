using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._30._2025.Models.task2
{
    internal class Student
    {
        public string fullName;
        public int GroupNo;
        public int AvgPoint;
        public Student(string fullName, int GroupNo, int AvgPoint)
        {
            this.fullName = fullName;
            this.GroupNo = GroupNo;
            this.AvgPoint = AvgPoint;
        }
    }
}
