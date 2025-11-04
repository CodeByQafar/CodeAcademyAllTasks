using ClassTask11._04._2025.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11._04._2025.Models
{
    internal class Library<T> where T : Book
    {
 public       List<T> books;

     static public   Predicate<T> condition =book =>book.genre==Genre.fantasy ;

        public Library(List<T> books)
        {
            this.books = books;
        }
 

        public List<T> FilterByPrice(int min, int max)
        {
            List<T> res = new List<T>();
            foreach (T book in books)
            {
                if (book.Price > min && book.Price < max)
                {
                    res.Add(book);
                }
            }
            return res;
        }

        public List<T> FilterByGenre(Genre genre)
        {
            List<T> res = new List<T>();
            foreach (T book in books)
            {
                if (book.genre == genre)
                {
                    res.Add(book);

                }
            }
            return res;
        }

        public dynamic FindBookByNo(int No)
        {
       
            foreach (T book in books)
            {
                if (book.No == No)
                {
                 return book;
                }
            }
            return null;
        }

        public dynamic isExistBookByNo(int No)
        {

            foreach (T book in books)
            {
                if (book.No == No)
                {
                    return true;
                    
                }
            }
            return false;
        }

        public void RemoveAll(Predicate<T> predicate)
        {
            books.RemoveAll(predicate);
        }
    }

}
