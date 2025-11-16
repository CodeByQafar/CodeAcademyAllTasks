using MetingApp_Helpers;
namespace MetingApp_Models
{
    public static class MeetingSchedule
    {
        public static List<Meeting> Meetings = new List<Meeting>();


        public static void SetMeeting(string Name, DateTime FromDate, DateTime ToDate)
        {
            bool isOverlaping = false;
            foreach (Meeting meeting in Meetings)
            {
                if (FromDate < meeting.ToDate && ToDate > meeting.FromDate)
                {
                    isOverlaping = true;
                    break;
                }
            }
            if (!isOverlaping)
            {
                Meetings.Add(new Meeting(Name, FromDate, ToDate));

                Helpers.ConsoleWriteline(ConsoleColor.Green, "meeting elave olundu");
            }
            else
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "meetingler ust uste dusur");

            }

        }
        public static int FindMeetingsCount(DateTime time)
        {

            int count = Meetings.FindAll(e => e.FromDate < time).Count;
            return count;
        }
        public static bool IsExistsMeetingByName(string name)
        {
            int count = Meetings.FindAll(e => e.Name == name).Count;
            if (count > 0)
            {
                return true;
            }
            return false;
        }

        public static List<Meeting> GetExistMeetings(string name)
        {
            List<Meeting> filterredMeeting = Meetings.FindAll(e => e.Name == name);
            return filterredMeeting;
        }
    }
}
