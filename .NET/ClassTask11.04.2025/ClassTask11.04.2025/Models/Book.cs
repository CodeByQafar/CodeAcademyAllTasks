using ClassTask11._04._2025.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._04._2025.Models
{
    internal class Book
    {
        public int No;
        public string Name;
        public string AuthorName;
        public Genre genre;
        public int Price;

        public Book(int No, string Name, string AuthorName, Genre genre, int Price)
        {
            this.No = No;
            this.Name = Name;
            this.AuthorName = AuthorName;
            this.genre = genre;
            this.Price = Price;
        }
    }
}
