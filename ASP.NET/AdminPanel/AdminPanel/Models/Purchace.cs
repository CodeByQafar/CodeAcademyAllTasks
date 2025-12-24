using System.Text.RegularExpressions;

namespace AdminPanel.Models
{
    public class Purchace

    {
       public int Id { get; set; }
        public  string Name { get; set; }
        public string StatusReport { get; set; }
        public string Office { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public int GrossAmount { get; set; }
    }
}
