using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11._13._2025.Models
{
    public static class TaskManager
    {
        public static List<TaskItem> tasks = new List<TaskItem>();


        public static void addTask(TaskItem item)
        {
            int index = tasks.IndexOf(tasks.Find(e => e.Id == item.Id));
            if (index == -1)
            {
                tasks.Add(item);
                Console.WriteLine($"id: {item.Id} title: {item.Title} completed:{item.IsCompleted} time{item.time} is added");
            }
            else
            {
                Console.WriteLine("this id is used on other task task not added");
            }

        }

        public static void showTasks()
        {
            foreach (TaskItem task in tasks)
            {
                Console.WriteLine($"id: {task.Id} title: {task.Title} completed:{task.IsCompleted} time: {task.time}");
            }
        }

        public static void changeCompletedStatus(int id, bool isComplated)
        {
            int index = tasks.IndexOf(tasks.Find(e => e.Id == id));
            if (tasks.Count != 0 && index != -1)
            {
                tasks[index].IsCompleted = isComplated;
                Console.WriteLine("task status changed");

            }
            else
            {
                Console.WriteLine("you don't have any task or this id task does not match any task");
            }

        }

        public static void deleteTask(int id)
        {
            int index = tasks.IndexOf(tasks.Find(e => e.Id == id));
            if (tasks.Count != 0 && index != -1)
            {
                tasks.Remove(tasks.Find(e => e.Id == id));
                Console.WriteLine("task is deleted");
            }
            else
            {
                Console.WriteLine("you don't have any task or this id task does not match any task");
            }

        }
    }
}
