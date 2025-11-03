using ClassTask10._31._2025.Models.task1;
using ClassTask10._31._2025.Models.task2;
using System;
namespace MyApp
{
    class Program
    {
        static void Main()
        {
            Basket<Fruit> basket = new Basket<Fruit>();
            basket.AddFruit(new Apple("A"));
            basket.AddFruit(new Pineapple("D"));
            basket.AddFruit(new Lemon("C"));
            Console.WriteLine(basket.fruits[0].vitamin);
            Console.WriteLine(basket.fruits[1].vitamin);
            Console.WriteLine(basket.fruits[2].vitamin);

            new MainPrintFile<Word>();
            new MainPrintFile<Excel>();
            new MainPrintFile<PDF>();
        }
    }
}