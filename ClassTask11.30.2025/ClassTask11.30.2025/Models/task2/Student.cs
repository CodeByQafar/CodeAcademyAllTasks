using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._30._2025.Models.task2
{
    internal class Student
    {
        string fullName;
        int GroupNo;
        int AvgPoint;
        public Student(string fullName, int GroupNo, int AvgPoint)
        {
            this.fullName = fullName;
            this.GroupNo = GroupNo;
            this.AvgPoint = AvgPoint;
        }

    }
}
