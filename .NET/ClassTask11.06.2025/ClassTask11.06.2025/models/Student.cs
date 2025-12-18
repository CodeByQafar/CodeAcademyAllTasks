using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentModel
{
    internal class Student
    {

        public  int No;
        public static int no = 0;
        public string FullName;
        public Dictionary<string, int> Exams;
        public Student(string FullName, Dictionary<string, int> Exams)
        {
            no++;
            No = no;
            this.FullName = FullName;
            this.Exams = Exams;
          
        }

        public void AddExam(string examName, int point)
        {
            Exams.Add(examName, point);
        }

        public int getExamResult(string examName)
        {
            return Exams[examName];
        }


        public int GetExamAvg()
        {
            int res = 0;
            int count = 0;
            foreach (var item in Exams)
            {
                count++;
                res += item.Value;
            }
            return res/count;
        }
        public void deleteExam(string examName)
        {
            Exams.Remove(examName);
        }
   
        //Dictionary<string, int> exam = new Dictionary<string, int>()
        //{
        //    {"Math", 97},
        //    {"Geography", 67},
        //};
    }
}
