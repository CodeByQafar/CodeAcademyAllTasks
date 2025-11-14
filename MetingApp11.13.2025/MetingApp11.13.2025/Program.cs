using MetingApp11._13._2025.Models;

namespace MyApp
{
    class Program
    {
        public static void Main()
        {
        //    MeetingSchedule.SetMeeting("Team Meeting",
        //new DateTime(2025, 11, 14, 10, 0, 0),
        //new DateTime(2025, 11, 14, 11, 0, 0));

        //    // İkinci görüş (üst-üstə düşmür)
        //    MeetingSchedule.SetMeeting("Client Call",
        //        new DateTime(2025, 11, 14, 11, 30, 0),
        //        new DateTime(2025, 11, 14, 12, 30, 0));

        //    // Üçüncü görüş (üst-üstə düşür)
        //    MeetingSchedule.SetMeeting("Project Review",
        //        new DateTime(2025, 11, 14, 10, 30, 0),
        //        new DateTime(2025, 11, 14, 11, 30, 0));

        //    Console.WriteLine("\nƏlavə olunmuş görüşlər:");
            foreach (var m in MeetingSchedule.Meetings)
            {
                Console.WriteLine($"{m.Name}: {m.FromDate} - {m.ToDate}");
            }


            try
            {
                Console.WriteLine("1. Yeni Meeting elave et");
                Console.WriteLine("2. Tarixdən sonra başlanan meetinglerin sayı");
                Console.WriteLine("3. Ad üzre meeting mövcudluğunu yoxla");
                Console.WriteLine("4. Ad üzre mövcud meetingleri göstər");
                Console.WriteLine("5. Bütün meetingleri göster");
                Console.WriteLine("0. Çıxış");
                Console.Write("Seçiminizi edin: ");

            repeat: int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        CreateMetting();
                        goto repeat;
                        break;
                    case 2:

                        goto repeat;

                        break;
                    case 3:
                        goto repeat;
                    case 4:
                        goto repeat;

                        break;
                    case 5:
                        goto repeat;
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        goto repeat;

                        break;
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void CreateMetting()
        {
            DateTime startTime;
            DateTime endtTime; 

            Console.WriteLine("meting adi daxil edin");

            string title = Console.ReadLine();

        hour: Console.WriteLine("meting baslama satin daxil edin");
            int hour;
            bool isHour = int.TryParse(Console.ReadLine(), out hour);
            if (!isHour)
            {
                Console.WriteLine("duzgun tip daxil edin");
                goto hour;
            }
            else if (hour <= 0 || hour >= 60)
            {
                Console.WriteLine("saat 0 ve 60 arasinda ola biler");
                goto hour;
            }
        minute: Console.WriteLine("meting baslama deyqesin daxil edin");
            int minute;
            bool isminute = int.TryParse(Console.ReadLine(), out minute);
            if (!isminute)
            {
                Console.WriteLine("duzgun tip daxil edin");
                goto minute;
            }
            else if (minute <= 0 || minute >= 60)
            {
                Console.WriteLine("saat 0 ve 60 arasinda ola biler");
                goto minute;
            }





        endhour: Console.WriteLine("meting bitme satin daxil edin");
            int endhour;
            bool isendHour = int.TryParse(Console.ReadLine(), out endhour);
            if (!isendHour)
            {
                Console.WriteLine("duzgun tip daxil edin");
                goto endhour;
            }
            else if (endhour <= 0 ||  endhour >= 60)
            {
                Console.WriteLine("saat 0 ve 60 arasinda ola biler");
                goto endhour;
            }
        endminute: Console.WriteLine("meting bitme deyqesin daxil edin");
            int endminute;
            bool isendminute = int.TryParse(Console.ReadLine(), out endminute);
            if (!isendminute)
            {
                Console.WriteLine("duzgun tip daxil edin");
                goto endminute;
            }
            else if (endminute <= 0 || endminute >= 60)
            {
                Console.WriteLine("saat 0 ve 60 arasinda ola biler");
                goto endminute;
            }
            endtTime = new DateTime(0, 0, 0, endhour, endminute, 0);
            startTime=  new DateTime(0, 0, 0, hour, minute, 0);

            MeetingSchedule.SetMeeting(title, startTime, endtTime);
    
      
        }
    }
}
