using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11._13._2025.Models
{
    public abstract class TaskBase
    {


        public int Id;
        public string Title;
        public bool IsCompleted;

        public TaskBase(int id, string title, bool isCompleted)
        {
            Id = id;
            Title = title;
            IsCompleted = isCompleted;
        }
        public abstract void Print();
    }
}
