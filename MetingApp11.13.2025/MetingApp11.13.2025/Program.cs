using MetingApp_Helpers;
using MetingApp_Models;
using MetingApp_Controllers;

namespace MyApp
{
    class Program
    {
        public static void Main()
        {
      Controller.showMenu();
        repeat:
            int option;
            bool isOption = int.TryParse(Console.ReadLine(), out option);
            if (!isOption)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "eded tipinde ve 0-6 arasi secim edin");
                goto repeat;
            }
            switch (option)
            {
                case 1:
                    Controller.CreateMetting();
                    goto repeat;
                case 2:
                    Controller.FindMeetingsCount();
                    goto repeat;
                case 3:
                    Controller.CheckMeetingByName();
                    goto repeat;
                case 4:
                    Controller.GetMeetingsByName();
                    goto repeat;
                case 5:
                    Controller.showAllMeetings();
                    goto repeat;          
                case 6:
                    Controller.clearConsole();
                    goto repeat;                
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Helpers.ConsoleWriteline(ConsoleColor.Red, "Duzgun secim edin");
                    goto repeat;
            }
        }
    }
}

