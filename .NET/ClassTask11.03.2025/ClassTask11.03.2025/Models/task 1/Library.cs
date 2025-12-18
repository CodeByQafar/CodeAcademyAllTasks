using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassTask11._03._2025.Models
{
    internal class Library<T> where T : Book

    {
        List<T> books;
        public Library(List<T> books)
        {
            this.books = books;
        }

        public List<T> FindAllBooksByName(string name)
        {
            List<T> res = new List<T>();
            foreach (T book in books)
            {
                if (book.name == name)
                {
                    res.Add(book);


                }
            }
            showAllBookInfo(res);

            return res;

        }


        public void RemoveAllBookByName(string name)
        {
            books.RemoveAll(element => element.name == name);
            showAllBookInfo(books);

        }


        public List<T> SearchBooks(string value)
        {

            List<T> res = new List<T>();
            foreach (T book in books)
            {
                if (book.name == value || book.pageCount == value || book.authorName == value)
                {
                    res.Add(book);
                }
            }

            showAllBookInfo(res);
            return res;
        }
        public void showAllBookInfo(List<T> books)
        {
            foreach (T book in books)
            {
                Console.WriteLine($"name:{book.name} author name:{book.authorName} page count:{book.pageCount}");

            }
        }
    }
}
