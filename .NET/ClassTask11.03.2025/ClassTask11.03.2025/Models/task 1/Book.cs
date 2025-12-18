using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._03._2025.Models
{
    internal class Book
    {
      public  string name;
      public  string authorName;
      public  string pageCount;
      public Book(string name, string authorName, string pageCount)
        {
            this.name = name;
            this.authorName = authorName;
            this.pageCount = pageCount;
        }
    }
}
