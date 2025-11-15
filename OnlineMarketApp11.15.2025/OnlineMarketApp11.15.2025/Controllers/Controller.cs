using OnlineMarketApp_Exceptions;
using OnlineMarketApp_Helpers;
using OnlineMarketApp_Models;
using OnlineMarketApp_Product_Models;

namespace OnlineMarketApp_Controllers
{

    public static class Controller
    {
        public static void clearConsole()
        {
            Console.Clear();
            showMenu();
        }
        public static void showMenu()
        {
            Console.WriteLine(
        "1.Show all products \n" +
        "2.Add new product\n" +
        "3.Remove product\n" +
        "4.Find product by ID\n" +
        "5.Show cart\n" +
        "6.Add product to cart\n" +
        "7.Find cart item by ID\n" +
        "8.Check if cart item exists\n" +
        "9.Clear console\n" +
        "0.Exit\n"
        );
        }

        public static void ShowAllProducts(OnlineMarket market)
        {
            market.ShowProducts();
        }

        public static void AddNewProduct(OnlineMarket market)
        {
            string Name;
            int Stock;
            double Price;

            Helpers.ConsoleWriteline(ConsoleColor.Blue, "Enter product name:");
            Name = Console.ReadLine();


        Stock: Helpers.ConsoleWriteline(ConsoleColor.Blue, "Enter product stock:");
            bool isStockValid = int.TryParse(Console.ReadLine(), out Stock);
            if (!isStockValid)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "Invalid stock value. Please enter a valid integer.");
                goto Stock;
            }
        Price: Helpers.ConsoleWriteline(ConsoleColor.Blue, "Enter product price:");
            bool isPriceValid = double.TryParse(Console.ReadLine(), out Price);
            if (!isPriceValid)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "Invalid price value. Please enter a valid number.");
                goto Price;
            }
            Product newProduct = new Product(Name, Stock, Price);
            market.AddProduct(newProduct);
            Helpers.ConsoleWriteline(ConsoleColor.Green, "Product added successfully.");
        }

        public static void RemoveProduct(OnlineMarket market)
        {
            int id;
        id: Helpers.ConsoleWriteline(ConsoleColor.Blue, "Enter product Id to remove:");
            bool isId = int.TryParse(Console.ReadLine(), out id);
            if (!isId)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, "Invalid Id value. Please enter a valid integer.");
                goto id;
            }
            try
            {
                market.RemoveProduct(id);
                Helpers.ConsoleWriteline(ConsoleColor.Green, "Product removed successfully");
            }
            catch (ProductNotFound ex)
            {
                Helpers.ConsoleWriteline(ConsoleColor.Red, ex.Message);
            }
        }

        public static void FindProductById(OnlineMarket market)
        {
        }

        public static void ShowCart(OnlineMarket market)
        {
        }

        public static void AddProductToCart(OnlineMarket market)
        {
        }

        public static void FindCartItemById(OnlineMarket market)
        {
        }

        public static void CheckCartItemExists(OnlineMarket market)
        {
        }

    }
}
