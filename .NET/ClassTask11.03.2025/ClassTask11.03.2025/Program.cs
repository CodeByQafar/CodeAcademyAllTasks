using ClassTask10._31._2025.Models.task1;
using ClassTask11._03._2025.Models;
using ClassTask11._03._2025.Models.task_2;

namespace MyApp
{
    class Program
    {
        public static void Main()
        {
            List<Book> books = new List<Book>()
        {
            new Book("Book 1", "Author A", "120"),
            new Book("Book 1", "Author B", "250"),
            new Book("Book 3", "Author C", "300"),
            new Book("Book 4", "Author D", "180"),
            new Book("Book 5", "Author E", "220"),
            new Book("Book 6", "Author F", "150"),
            new Book("Book 7", "Author G", "400"),
            new Book("Book 8", "Author H", "330"),
            new Book("Book 8", "Author H", "210"),
            new Book("Book 10", "Author J", "270")
        };

            Library<Book> library = new Library<Book>(books);


            library.FindAllBooksByName("Book 1");
            Console.WriteLine("============");

            library.SearchBooks("Author H");
            Console.WriteLine("============");

            library.RemoveAllBookByName("Book 8");

            Console.WriteLine("============");


            Basket<Fruit> basket = new Basket<Fruit>();
            basket.AddFruit(new Apple("A"));
            basket.AddFruit(new Pineapple("D"));
            basket.AddFruit(new Lemon("C"));
            Console.WriteLine(basket.fruits[0].vitamin);
            Console.WriteLine(basket.fruits[1].vitamin);
            Console.WriteLine(basket.fruits[2].vitamin);


            Console.WriteLine("============");


            List<Language> languages = new List<Language>()
            {
              new Language("C", 1972),
            new Language("C++", 1983),
            new Language("C#", 2000),
            new Language("Java", 1995),
            new Language("Python", 1991),
            new Language("JavaScript", 1995),
            new Language("Go", 2009),
            new Language("Ruby", 1995),
            new Language("Swift", 2014),
            new Language("Kotlin", 2011)
            };

            List<Language> sortByNames = languages.OrderBy(element => element.name).ToList();
            List<Language> sortByYears = languages.OrderBy(element => element.year).ToList();


            foreach (Language language in sortByNames)
            {
                Console.WriteLine(language.name + language.year);
            }
            Console.WriteLine("============");
            foreach (Language language in sortByYears)
            {
                Console.WriteLine(language.name + language.year);
            }
        }
    }
}