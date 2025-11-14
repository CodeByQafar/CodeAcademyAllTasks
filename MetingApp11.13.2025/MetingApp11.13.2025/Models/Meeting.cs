using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetingApp11._13._2025.Models
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
