using ClassTask11._07._2025.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._07._2025.Models
{
    class Book : Product
    {
        public string AuthorName;
        public int PageCount;
        public Book(string Name, int Price, int Count, int TotalInCome, string AuthorName, int PageCount) : base(Name, Price, Count, TotalInCome)
        {
            this.AuthorName = AuthorName;
            this.PageCount = PageCount;
        }
        public override void Sell()
        {

            if (Count-1 < 0)
            {

                throw new ProductCountIsZeroException("Product count is zero you can't sell book");
            }
            else
            {
                TotalInCome+=Price;
                Count--;
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"name:{Name}\nprice:{Price}\ncount:{Count}\ntotal come:{TotalInCome}\nauthor name:{AuthorName}\npage count:{PageCount}\n");
        }
    }
}
