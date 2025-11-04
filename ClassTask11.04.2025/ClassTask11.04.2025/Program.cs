using ClassTask11._04._2025.Deligates;
using ClassTask11._04._2025.Enums;
using ClassTask11._04._2025.Models;

namespace MyApp
{
    class Program
    {
        public static void Main(string[] args) {
            List<Book> books = new List<Book>()
            {
                new Book(1, "1984", "George Orwell", Genre.fiction, 15),
                new Book(2, "Brave New World", "Aldous Huxley", Genre.scienceFiction, 20),
                new Book(3, "The Hobbit", "J.R.R. Tolkien", Genre.fantasy, 25),
                new Book(4, "Sherlock Holmes", "Arthur Conan Doyle", Genre.mystery, 18),
                new Book(5, "Pride and Prejudice", "Jane Austen", Genre.romance, 12),
                new Book(6, "Dracula", "Bram Stoker", Genre.horror, 16),
                new Book(7, "Steve Jobs", "Walter Isaacson", Genre.biography, 22),
                new Book(8, "Sapiens", "Yuval Noah Harari", Genre.history, 30),
                new Book(9, "Atomic Habits", "James Clear", Genre.selfHelp, 14),
                new Book(10, "Harry Potter", "J.K. Rowling", Genre.fantasy, 28),
            };

            // Library nümunəsi yaradılır
            Library<Book> myLibrary = new Library<Book>(books);

            Console.WriteLine("Books priced between 15 and 25:");
            var filteredByPrice = myLibrary.FilterByPrice(15, 25);
            foreach (var book in filteredByPrice)
                Console.WriteLine($"{book.Name} - ${book.Price}");

          
            Console.WriteLine("\nFantasy books:");
            var fantasyBooks = myLibrary.FilterByGenre(Genre.fantasy);
            foreach (var book in fantasyBooks)
                Console.WriteLine($"{book.Name} by {book.AuthorName}");

         
            Console.WriteLine("\nFind book with No = 3:");
            var foundBook = myLibrary.FindBookByNo(3);
            if (foundBook != null)
                Console.WriteLine($"{foundBook.Name} by {foundBook.AuthorName}");

           
            Console.WriteLine("\nIs book No = 7 exist?");
            bool exists = myLibrary.isExistBookByNo(7);
            Console.WriteLine(exists); 

      
            Console.WriteLine("\nRemoving all fantasy books...");
            myLibrary.RemoveAll(Library<Book>.condition);

            var remainingFantasy = myLibrary.FilterByGenre(Genre.fantasy);
            Console.WriteLine("Remaining fantasy books count: " + remainingFantasy.Count);
            int res = Deligates.sum(34,98);
            Deligates.result(res, "Message");

            TemperatureSensor.tempurator(12);
            TemperatureSensor.tempurator(32);
            TemperatureSensor.tempurator(22);
            TemperatureSensor.tempurator(35);
        }
    }
    }
