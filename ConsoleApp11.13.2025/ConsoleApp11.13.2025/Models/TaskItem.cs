using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11._13._2025.Models
{
    public class TaskItem : TaskBase
    {
        public DateTime time;
        public TaskItem(int id, string title, bool isCompleted) : base(id, title, isCompleted)
        {
            time = DateTime.Now;
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }
    }
}
