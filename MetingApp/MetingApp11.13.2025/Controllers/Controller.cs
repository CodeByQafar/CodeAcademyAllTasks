using MetingApp_Helpers;
using MetingApp_Models;


namespace MetingApp_Controllers
{
    public class Controller
    {
        public static void clearConsole()
        {
            Console.Clear();
            showMenu();
        }
        public static void showMenu()
        {
            Console.WriteLine("\n1. Yeni Meeting elave et");
            Console.WriteLine("2. Tarixden sonra başlanan meetinglerin sayı");
            Console.WriteLine("3. Ad üzre meeting mövcudluğunu yoxla");
            Console.WriteLine("4. Ad üzre mövcud meetingleri göstər");
            Console.WriteLine("5. Bütün meetingleri göster");
            Console.WriteLine("6. Consolu temizleyin");
            Console.WriteLine("0. Çıxış");
            Console.Write("\nSeçiminizi edin: ");
        }
        public static void CheckMeetingByName()
        {
            Helpers.ConsoleWriteline(ConsoleColor.Blue, "meting adi daxil edin");

            string title = Console.ReadLine();
            bool isExitMetting = MeetingSchedule.IsExistsMeetingByName(title);
            if (isExitMetting)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Green, "bele bir meeting var");
            }
            else
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "bele bir meeting yoxdur");
            }
        }
        public static void GetMeetingsByName()
        {
            Helpers.ConsoleWriteline(ConsoleColor.Blue, "meting adi daxil edin");

            string title = Console.ReadLine();
            List<Meeting> mettings = MeetingSchedule.GetExistMeetings(title);
            foreach (Meeting meeting in mettings)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Yellow, $"Meeting adi: {meeting.Name} Meeting baslama zamani: {meeting.FromDate} Meeting bitme zamani: {meeting.ToDate}");
            }
        }
        public static void showAllMeetings()
        {
            foreach (Meeting meeting in MeetingSchedule.Meetings)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Yellow, $"Meeting adi: {meeting.Name} Meeting baslama zamani: {meeting.FromDate} Meeting bitme zamani: {meeting.ToDate}");
            }
            if (MeetingSchedule.Meetings.Count == 0)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "Her hansisa bir meeting yoxdur");
            }
        }
        public static void FindMeetingsCount()
        {
            DateTime time;

        hour: Helpers.ConsoleWriteline(ConsoleColor.Blue, "meting baslama satin daxil edin");
            int hour;
            bool isHour = int.TryParse(Console.ReadLine(), out hour);
            if (!isHour)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "duzgun tip daxil edin");
                goto hour;
            }
            else if (hour <= 0 || hour >= 24)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "saat 0 ve 60 arasinda ola biler");
                goto hour;
            }
        minute: Helpers.ConsoleWriteline(ConsoleColor.Blue, "meting baslama deyqesin daxil edin");
            int minute;
            bool isminute = int.TryParse(Console.ReadLine(), out minute);
            if (!isminute)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "duzgun tip daxil edin");
                goto minute;
            }
            else if (minute <= 0 || minute >= 60)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "saat 0 ve 60 arasinda ola biler");
                goto minute;
            }

            int count = MeetingSchedule.FindMeetingsCount(new DateTime(2025, 11, 14, hour, minute, 0));
            Helpers.ConsoleWriteline(ConsoleColor.Green, $"Bu tarxiden sonra baslayan {count} eded meeting var");
        }
        public static void CreateMetting()
        {
            DateTime startTime;
            DateTime endtTime;

            Helpers.ConsoleWriteline(ConsoleColor.Blue, "meting adi daxil edin");

            string title = Console.ReadLine();

        hour: Helpers.ConsoleWriteline(ConsoleColor.Blue, "meting baslama satin daxil edin");
            int hour;
            bool isHour = int.TryParse(Console.ReadLine(), out hour);
            if (!isHour)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "duzgun tip daxil edin");
                goto hour;
            }
            else if (hour <= 0 || hour >= 24)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "saat 0 ve 60 arasinda ola biler");
                goto hour;
            }
        minute: Helpers.ConsoleWriteline(ConsoleColor.Blue, "meting baslama deyqesin daxil edin");
            int minute;
            bool isminute = int.TryParse(Console.ReadLine(), out minute);
            if (!isminute)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "duzgun tip daxil edin");
                goto minute;
            }
            else if (minute <= 0 || minute >= 60)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "saat 0 ve 60 arasinda ola biler");
                goto minute;
            }

        endhour: Helpers.ConsoleWriteline(ConsoleColor.Blue, "meting bitme satin daxil edin");
            int endhour;
            bool isendHour = int.TryParse(Console.ReadLine(), out endhour);
            if (!isendHour)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "duzgun tip daxil edin");
                goto endhour;
            }
            else if (endhour <= 0 || endhour >= 24)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "saat 0 ve 60 arasinda ola biler");
                goto endhour;
            }
        endminute: Helpers.ConsoleWriteline(ConsoleColor.Blue, "meting bitme deyqesin daxil edin");
            int endminute;
            bool isendminute = int.TryParse(Console.ReadLine(), out endminute);
            if (!isendminute)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "duzgun tip daxil edin");
                goto endminute;
            }
            else if (endminute <= 0 || endminute >= 60)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "saat 0 ve 60 arasinda ola biler");
                goto endminute;
            }
            endtTime = new DateTime(2025, 11, 11, endhour, endminute, 0);
            startTime = new DateTime(2025, 11, 11, hour, minute, 0);
            if (endtTime < startTime)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "bitme zamani baslama zamanindan boyuk olmalidir");
                goto endhour;
            }
            MeetingSchedule.SetMeeting(title, startTime, endtTime);
        }
    }
}
