using ConsoleApp11._13._2025.Models;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. Yeni tapşırıq elave et\r\n2. Tapşırıqları göster\r\n3. Tapşırığı tamamlanma statusun deyis\r\n4. Tapşırığı sil\r\n5. Çıxış et");
        repeat:
            int option;
            bool isOption = int.TryParse(Console.ReadLine(), out option);
      
                switch (option)
                {

                    case 1:
                        addTask();
                        goto repeat;
                    case 2:
                        showTask();
                        goto repeat;
                    case 3:

                        changeCompletedStatus();
                        goto repeat;
                    case 4:
                        deleteTask();
                        goto repeat;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("bele bir secim yoxdur");
                        goto repeat;
                }
            
        }

        static public void addTask()
        {
        taskId:
            Console.WriteLine("enter task id");
            int id;
            bool isId = int.TryParse(Console.ReadLine(), out id);
            if (!isId)
            {
                Console.WriteLine("only number");
                goto taskId;

            }

            Console.WriteLine("enter task title ");
            string title = Console.ReadLine();

        isComplated:
            Console.WriteLine("enter is comptlated true/false");
            bool complated;
            bool isBoolType = bool.TryParse(Console.ReadLine(), out complated);
            if (!isBoolType)
            {
                Console.WriteLine("only true or false");
                goto isComplated;

            }

            TaskManager.addTask(new TaskItem(id, title, complated));
        }

        static public void showTask()
        {

            TaskManager.showTasks();
        }
        static public void changeCompletedStatus()
        {
        taskId:
            Console.WriteLine("enter task id");
            int id;
            bool isId = int.TryParse(Console.ReadLine(), out id);
            if (!isId)
            {
                Console.WriteLine("only number");
                goto taskId;

            }

           
        isComplated:
            Console.WriteLine("enter is comptlated true/false");
            bool complated;
            bool isBoolType = bool.TryParse(Console.ReadLine(), out complated);
            if (!isBoolType)
            {
                Console.WriteLine("only true or false");
                goto isComplated;

            }
            TaskManager.changeCompletedStatus(id, complated);
        }


        static public void deleteTask()
        {
        taskId:
            Console.WriteLine("enter task id");
            int id;
            bool isId = int.TryParse(Console.ReadLine(), out id);
            if (!isId)
            {
                Console.WriteLine("only number ");
                goto taskId;

            }


            TaskManager.deleteTask(id);
        }
    }
}