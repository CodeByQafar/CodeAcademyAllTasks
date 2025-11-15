

namespace MetingApp_Models
{
    public class Meeting
    {

        public string Name;
        public DateTime FromDate;
        public DateTime ToDate;
        public Meeting(string Name, DateTime FromDate, DateTime ToDate)
        {
            this.Name = Name;
            this.FromDate = FromDate;   
            this.ToDate = ToDate;
        }

    }
}
